// <copyright file="RootQuery.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Queries
{
    using GraphQL.Types;

    /// <summary>
    /// The root GraphQL query.
    /// </summary>
    public class RootQuery : ObjectGraphType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RootQuery"/> class.
        /// </summary>
        public RootQuery()
        {
            this.Field<TelemetryQuery>("telemetryQuery", resolve: _ => new { });
        }
    }
}
