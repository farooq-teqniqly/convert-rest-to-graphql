// <copyright file="TelemetryQuery.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Queries
{
    using System;
    using System.Linq;
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
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<TimeSpanSecondsGraphType>>
                                {
                                    Name = "since",
                                    Description = "The max age in seconds of the returned telemetry.",
                                },
                    new QueryArgument<StringGraphType>
                                {
                                    Name = "deviceId",
                                    Description = "The device id to return telemetry for.",
                                }),
                resolve: async ctx =>
                {
                    var sinceDt = DateTime.Now.Subtract((TimeSpan)ctx.Arguments!["since"].Value!);
                    var deviceId = ctx.Arguments!["deviceId"].Value! as string;

                    var query = dbContext.Telemetries.Where(t => t.Timestamp >= sinceDt);

                    if (deviceId != null)
                    {
                        query = query.Where(t => t.DeviceId == deviceId);
                    }

                    return await query.ToListAsync();
                });
        }
    }
}
