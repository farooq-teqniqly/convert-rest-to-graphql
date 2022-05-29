// <copyright file="TelemetrySchema.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Schemas
{
    using DataAccess.Graph.Queries;
    using GraphQL.Types;

    /// <summary>
    /// The Telemetry query schema.
    /// </summary>
    public class TelemetrySchema : Schema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetrySchema"/> class.
        /// </summary>
        /// <param name="query">The query associated with this schema.</param>
        public TelemetrySchema(TelemetryQuery query)
        {
            this.Query = query;
        }
    }
}
