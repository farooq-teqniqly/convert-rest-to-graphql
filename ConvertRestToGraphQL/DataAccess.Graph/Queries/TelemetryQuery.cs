// <copyright file="TelemetryQuery.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Queries
{
    using DataAccess.EFCore;
    using DataAccess.Graph.Types;
    using GraphQL.Types;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Telemetry query.
    /// </summary>
    public class TelemetryQuery : ObjectGraphType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryQuery"/> class.
        /// </summary>
        /// <param name="dbContext">The EF Core database context.</param>
        public TelemetryQuery(TelemetryDbContext dbContext)
        {
            this.FieldAsync<ListGraphType<NonNullGraphType<TelemetryType>>>(
                "telemetry",
                resolve: async _ => await dbContext.Telemetries.ToListAsync());
        }
    }
}
