// <copyright file="GetDeviceTelemetryEnvelopeModel.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents the response to a telemetry query for a specific device.
    /// </summary>
    public class GetDeviceTelemetryEnvelopeModel
    {
        /// <summary>
        /// Gets or sets the result count.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list of telemetries.
        /// </summary>
        public List<GetDeviceTelemetryResponseModel> Telemetries { get; set; }
    }
}
