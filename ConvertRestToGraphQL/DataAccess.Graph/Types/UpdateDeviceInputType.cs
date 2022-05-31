// <copyright file="UpdateDeviceInputType.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Types
{
    using GraphQL.Types;

    /// <summary>
    /// Encapsulates a device metadata update.
    /// </summary>
    public class UpdateDeviceInputType : InputObjectGraphType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeviceInputType"/> class.
        /// </summary>
        public UpdateDeviceInputType()
        {
            this.Field<NonNullGraphType<StringGraphType>>("deviceId");
            this.Field<StringGraphType>("description");
            this.Field<StringGraphType>("department");
            this.Field<StringGraphType>("firmwareVersion");
            this.Field<DateTimeGraphType>("dateAcquired");
        }
    }
}
