// <copyright file="GetTelemetryEnvelopeModel.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents the response to a telemetry query.
    /// </summary>
    public class GetTelemetryEnvelopeModel
    {
        /// <summary>
        /// Gets or sets the result count.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list of telemetries.
        /// </summary>
        public List<GetTelemetryResponseModel> Telemetries { get; set; }
    }
}