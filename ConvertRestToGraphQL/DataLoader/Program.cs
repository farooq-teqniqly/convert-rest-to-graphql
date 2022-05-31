// <copyright file="Program.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataLoader
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using CsvHelper;
    using DataAccess.EFCore;
    using DataAccess.EFCore.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// The DataLoader program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point.
        /// </summary>
        /// <param name="args">Arguments to the program.</param>
        /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
        public static async Task Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            var waitForTime = TimeSpan.Parse(configuration["DataLoader:WaitForSqlStartupTime"]);
            Console.WriteLine(waitForTime);

            await Task.Delay(waitForTime);

            var connectionString = configuration["DataLoader:ConnectionString"];
            var dataFile = configuration["DataLoader:DataFile"];

            Console.WriteLine(connectionString);

            var records = await ReadCsv(dataFile);
            NormalizeTimestamps(records);
            await InsertData(connectionString, records);
        }

        private static void NormalizeTimestamps(List<Telemetry> records)
        {
            Console.WriteLine("Normalizing timestamps...");

            var distinctTimestamps = records.Select(r => r.Timestamp).Distinct().OrderByDescending(dt => dt);
            var map = new Dictionary<DateTime, DateTime>();
            var hours = 1;

            foreach (var timestamp in distinctTimestamps)
            {
                map.Add(timestamp, DateTime.Now.Subtract(TimeSpan.FromHours(hours++)));
            }

            foreach (var record in records)
            {
                record.Timestamp = map[record.Timestamp];
            }
        }

        private static async Task<List<Telemetry>> ReadCsv(string dataFile)
        {
            List<Telemetry> records;
            Console.WriteLine($"Reading CSV from '{dataFile}'...");

            using (var reader = new StreamReader(dataFile))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                await csv.ReadAsync();
                csv.ReadHeader();
                records = await ReadCsvRecords(csv).ToListAsync();
            }

            Console.WriteLine($"Read {records.Count} records from CSV.");
            return records;
        }

        private static async IAsyncEnumerable<Telemetry> ReadCsvRecords(CsvReader csv)
        {
            while (await csv.ReadAsync())
            {
                var record = new Telemetry
                {
                    Timestamp = csv.GetField<DateTime>("timestamp"),
                    DeviceId = csv.GetField("device_id"),
                    Voltage = csv.GetField<decimal>("volt"),
                    Rotation = csv.GetField<decimal>("rotate"),
                    Pressure = csv.GetField<decimal>("pressure"),
                    Vibration = csv.GetField<decimal>("vibration"),
                    DeviceStatus = csv.GetField("device_status"),
                    IpAddress = csv.GetField("ip_address"),
                };

                yield return record;
            }
        }

        private static async Task InsertData(string connectionString, List<Telemetry> records)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TelemetryDbContext>().UseSqlServer(connectionString);

            using (var dbContext = new TelemetryDbContext(optionsBuilder.Options))
            {
                Console.WriteLine("Deleting database...");
                await dbContext.Database.EnsureDeletedAsync();
                Console.WriteLine("Creating database...");
                await dbContext.Database.EnsureCreatedAsync();
                await InsertDevices(records, dbContext);
                await InsertTelemetries(records, dbContext);
            }
        }

        private static async Task InsertTelemetries(List<Telemetry> records, TelemetryDbContext dbContext)
        {
            await dbContext.Telemetries.AddRangeAsync(records);
            Console.WriteLine("Inserting telemetry rows...");
            var rowsInserted = await dbContext.SaveChangesAsync();
            Console.WriteLine($"Inserted {rowsInserted} telemetry rows.");
        }

        private static async Task InsertDevices(List<Telemetry> records, TelemetryDbContext dbContext)
        {
            var distinctDeviceIds = records.Select(t => t.DeviceId).Distinct().ToList();
            var departments = new string[] { "Facilities", "IT", "Finance", "Shipping" };
            var random = new Random();
            var devices = new List<Device>();

            foreach (var deviceId in distinctDeviceIds)
            {
                var department = departments[random.Next(0, departments.Length - 1)];

                devices.Add(new Device
                {
                    DeviceId = deviceId,
                    Description = deviceId,
                    Department = department,
                    FirmwareVersion = "1.0.0.0",
                    DateAcquired = DateTime.Now.Subtract(TimeSpan.FromDays(30)),
                });
            }

            await dbContext.Devices.AddRangeAsync(devices);
            Console.WriteLine("Inserting device rows...");
            var rowsInserted = await dbContext.SaveChangesAsync();
            Console.WriteLine($"Inserted {rowsInserted} device rows.");
        }
    }
}