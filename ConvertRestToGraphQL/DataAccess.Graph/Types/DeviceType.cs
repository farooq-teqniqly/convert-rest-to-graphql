// <copyright file="DeviceType.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Types
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DataAccess.EFCore.Entities;
    using GraphQL.Types;

    public sealed class DeviceType : ObjectGraphType<Device>
    {
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
