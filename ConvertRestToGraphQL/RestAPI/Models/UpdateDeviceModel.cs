// <copyright file="UpdateDeviceModel.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Models
{
    using System;

    /// <summary>
    /// Encapsulates a update device request.
    /// </summary>
    public class UpdateDeviceModel
    {
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
