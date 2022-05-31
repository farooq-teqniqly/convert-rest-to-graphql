// <copyright file="RootMutation.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Mutations
{
    using GraphQL.Types;

    /// <summary>
    /// The root GraphQL mutation.
    /// </summary>
    public class RootMutation : ObjectGraphType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RootMutation"/> class.
        /// </summary>
        public RootMutation()
        {
            Field<DeviceMutation>("deviceMutation", resolve: _ => new { });
        }
    }
}