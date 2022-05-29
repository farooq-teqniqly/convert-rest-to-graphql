// <copyright file="DeviceType.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Types
{
    using DataAccess.EFCore.Entities;
    using GraphQL.Types;

    /// <summary>
    /// The Device GraphQL type.
    /// </summary>
    public sealed class DeviceType : ObjectGraphType<Device>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceType"/> class.
        /// </summary>
        public DeviceType()
        {
            this.Field(e => e.DeviceId);
            this.Field(e => e.Description);
            this.Field(e => e.Department);
            this.Field(e => e.DateAcquired);
            this.Field(e => e.FirmwareVersion);
        }
    }
}
