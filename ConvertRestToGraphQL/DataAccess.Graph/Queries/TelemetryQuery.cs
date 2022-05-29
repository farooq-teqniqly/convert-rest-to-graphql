// <copyright file="TelemetryQuery.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

using System;
using System.Linq;

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
                "Returns device telemetry.",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<TimeSpanSecondsGraphType>> { Name = "since", Description = "The max age in seconds of the returned telemetry."}),
                resolve: async ctx =>
                {
                    var sinceDt = DateTime.Now.Subtract((TimeSpan)ctx.Arguments!["since"].Value!);

                    return await dbContext
                        .Telemetries
                        .Where(t => t.Timestamp >= sinceDt)
                        .ToListAsync();
                });
        }
    }
}
