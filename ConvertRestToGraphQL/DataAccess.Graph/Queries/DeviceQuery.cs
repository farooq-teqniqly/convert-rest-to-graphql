// <copyright file="DeviceQuery.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Queries
{
    using DataAccess.EFCore;
    using DataAccess.Graph.Types;
    using GraphQL.Types;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Device query.
    /// </summary>
    public class DeviceQuery : ObjectGraphType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceQuery"/> class.
        /// </summary>
        /// <param name="dbContext">The EF Core database context.</param>
        public DeviceQuery(TelemetryDbContext dbContext)
        {
            this.FieldAsync<ListGraphType<NonNullGraphType<DeviceType>>>(
                "devices",
                "Returns metadata for all devices.",
                resolve: async cts => await dbContext.Devices.ToListAsync());
        }
    }
}
