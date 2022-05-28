// <copyright file="Device.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Represents a device.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Gets or sets the device id.
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets the device description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the department that owns the device.
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets the date the device was acquired.
        /// </summary>
        public DateTime DateAcquired { get; set; }

        /// <summary>
        /// Gets or sets the firmware version installed on the device.
        /// </summary>
        public string FirmwareVersion { get; set; }
    }
}
