﻿// <copyright file="TelemetryType.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Types
{
    using DataAccess.EFCore;
    using DataAccess.EFCore.Entities;
    using GraphQL.Types;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The Telemetry GraphQL type.
    /// </summary>
    public sealed class TelemetryType : ObjectGraphType<Telemetry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryType"/> class.
        /// </summary>
        /// <param name="dbContext">The EF Core database context.</param>
        public TelemetryType(TelemetryDbContext dbContext)
        {
            this.Field(t => t.TelemetryId);
            this.Field(t => t.Timestamp);
            this.Field(t => t.Voltage);
            this.Field(t => t.Rotation);
            this.Field(t => t.Pressure);
            this.Field(t => t.Vibration);
            this.Field(t => t.DeviceStatus);
            this.Field(t => t.IpAddress);

            this.FieldAsync<DeviceType>(
                "device",
                resolve: async ctx =>
            {
                return await dbContext.Devices.SingleOrDefaultAsync(d => d.DeviceId == ctx.Source.DeviceId);
            });
        }
    }
}