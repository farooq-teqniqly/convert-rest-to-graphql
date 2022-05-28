// <copyright file="TelemetryController.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Controllers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using DataAccess.EFCore;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using RestAPI.Models;

    /// <summary>
    /// Endpoints for querying device telemetry.
    /// </summary>
    [ApiController]
    [Route("api/telemetry")]
    public class TelemetryController : ControllerBase
    {
        private readonly TelemetryDbContext dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryController"/> class.
        /// </summary>
        /// <param name="dbContext">The EF Core database context.</param>
        public TelemetryController(TelemetryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Gets telemetry for a device within a time window.
        /// </summary>
        /// <param name="deviceId">The device id.</param>
        /// <param name="since">Return data later than this time span.</param>
        /// <returns>The device telemetry.</returns>
        [HttpGet]
        [Route("{deviceId}")]
        [ProducesResponseType(typeof(ResponseEnvelopeModel<GetDeviceTelemetryResponseModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetDeviceTelemetry(string deviceId, [FromQuery] string since)
        {
            if (!EnsureTimeSpanIsValid(since, out TimeSpan ts))
            {
                return this.BadRequest("'since' query parameter is required and must be in a valid format.");
            }

            var sinceDt = DateTime.Now.Subtract(ts);

            var telemetries = await this.dbContext.Telemetries
                .Where(t => t.DeviceId == deviceId)
                .Where(t => t.Timestamp >= sinceDt)
                .Select(t => new GetDeviceTelemetryResponseModel
                {
                    TelemetryId = t.TelemetryId,
                    Timestamp = t.Timestamp,
                    Voltage = t.Voltage,
                    Vibration = t.Vibration,
                    Rotation = t.Rotation,
                    Pressure = t.Pressure,
                    DeviceStatus = t.DeviceStatus,
                    IpAddress = t.IpAddress,
                })
                .ToListAsync();

            return this.Ok(new ResponseEnvelopeModel<GetDeviceTelemetryResponseModel> { Count = telemetries.Count, Data = telemetries });
        }

        /// <summary>
        /// Gets telemetry for all devices within a time window.
        /// </summary>
        /// <param name="since">Return data later than this time span.</param>
        /// <returns>The device telemetry.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(ResponseEnvelopeModel<GetTelemetryResponseModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetTelemetry([FromQuery] string since)
        {
            if (!EnsureTimeSpanIsValid(since, out TimeSpan ts))
            {
                return this.BadRequest("'since' query parameter is required and must be in a valid format.");
            }

            var sinceDt = DateTime.Now.Subtract(ts);

            var telemetries = await this.dbContext.Telemetries
                .Where(t => t.Timestamp >= sinceDt)
                .Select(t => new GetTelemetryResponseModel
                {
                    TelemetryId = t.TelemetryId,
                    DeviceId = t.DeviceId,
                    Timestamp = t.Timestamp,
                    Voltage = t.Voltage,
                    Vibration = t.Vibration,
                    Rotation = t.Rotation,
                    Pressure = t.Pressure,
                    DeviceStatus = t.DeviceStatus,
                    IpAddress = t.IpAddress,
                })
                .ToListAsync();

            return this.Ok(new ResponseEnvelopeModel<GetTelemetryResponseModel> { Count = telemetries.Count, Data = telemetries });
        }

        private static bool EnsureTimeSpanIsValid(string since, out TimeSpan ts)
        {
            return TimeSpan.TryParse(since, out ts);
        }
    }
}