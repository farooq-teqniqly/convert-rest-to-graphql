// <copyright file="RootSchema.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Schemas
{
    using System;
    using DataAccess.Graph.Mutations;
    using DataAccess.Graph.Queries;
    using GraphQL.Types;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// The root GraphQL schema.
    /// </summary>
    public class RootSchema : Schema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RootSchema"/> class.
        /// </summary>
        /// <param name="serviceProvider">The IServiceProvider used for resolving dependencies.</param>
        public RootSchema(IServiceProvider serviceProvider)
        : base(serviceProvider)
        {
            this.Query = serviceProvider.GetRequiredService<RootQuery>();
            this.Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
