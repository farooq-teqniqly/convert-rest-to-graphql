// <copyright file="TelemetryType.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Types
{
    using DataAccess.EFCore;
    using DataAccess.EFCore.Entities;
    using GraphQL.Types;
    using Microsoft.EntityFrameworkCore;

    public sealed class TelemetryType : ObjectGraphType<Telemetry>
    {
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