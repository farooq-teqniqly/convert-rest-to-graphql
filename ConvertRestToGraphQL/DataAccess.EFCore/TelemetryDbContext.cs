// <copyright file="TelemetryDbContext.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore
{
    using DataAccess.EFCore.Entities;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// EF Core database context.
    /// </summary>
    public class TelemetryDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryDbContext"/> class.
        /// </summary>
        public TelemetryDbContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryDbContext"/> class.
        /// </summary>
        /// <param name="options">DbContext options.</param>
        public TelemetryDbContext(DbContextOptions<TelemetryDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Telemetries DbSet.
        /// </summary>
        public DbSet<Telemetry> Telemetries { get; set; }

        /// <summary>
        /// Gets or sets the Devices DbSet.
        /// </summary>
        public DbSet<Device> Devices { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Telemetry>(entity =>
            {
                entity.ToTable("Telemetry");
                entity.HasKey(t => t.TelemetryId);
                entity.Property(t => t.TelemetryId).ValueGeneratedOnAdd();
                entity.Property(t => t.Timestamp).IsRequired();
                entity.Property(t => t.DeviceId).IsRequired().HasMaxLength(10);
                entity.Property(t => t.Voltage).IsRequired().HasColumnType("decimal(5, 2)");
                entity.Property(t => t.Rotation).IsRequired().HasColumnType("decimal(5, 2)");
                entity.Property(t => t.Pressure).IsRequired().HasColumnType("decimal(5, 2)");
                entity.Property(t => t.Vibration).IsRequired().HasColumnType("decimal(4, 2)");
                entity.Property(t => t.DeviceStatus).IsRequired().HasMaxLength(10);
                entity.Property(t => t.IpAddress).IsRequired().HasMaxLength(15);
                entity.HasIndex(t => new { t.DeviceId, t.Timestamp });
                entity.HasIndex(t => t.Timestamp);
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("Device");
                entity.HasKey(d => d.DeviceId);
                entity.Property(t => t.DeviceId).IsRequired().HasMaxLength(10);
                entity.Property(t => t.Description).IsRequired().HasMaxLength(100);
                entity.Property(t => t.Department).IsRequired().HasMaxLength(20);
                entity.Property(t => t.DateAcquired).IsRequired();
                entity.Property(t => t.FirmwareVersion).IsRequired().HasMaxLength(10);
                entity.HasMany<Telemetry>();
            });
        }
    }
}
