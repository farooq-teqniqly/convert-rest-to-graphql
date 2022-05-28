// <copyright file="GetTelemetryResponseModel.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Models
{
    using System;

    /// <summary>
    /// Represents an API response that contains device telemetry.
    /// </summary>
    public class GetTelemetryResponseModel
    {
        /// <summary>
        /// Gets or sets the telemetry id.
        /// </summary>
        public Guid TelemetryId { get; set; }

        /// <summary>
        /// Gets or sets the device id.
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets the telemetry timestamp.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the reported voltage.
        /// </summary>
        public decimal Voltage { get; set; }

        /// <summary>
        /// Gets or sets the reported rotation.
        /// </summary>
        public decimal Rotation { get; set; }

        /// <summary>
        /// Gets or sets the reported pressure.
        /// </summary>
        public decimal Pressure { get; set; }

        /// <summary>
        /// Gets or sets the reported vibration.
        /// </summary>
        public decimal Vibration { get; set; }

        /// <summary>
        /// Gets or sets the reported device status.
        /// </summary>
        public string DeviceStatus { get; set; }

        /// <summary>
        /// Gets or sets the device IP address.
        /// </summary>
        public string IpAddress { get; set; }
    }
}
