namespace RestAPI.Controllers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using DataAccess.EFCore;
    using DataAccess.EFCore.Entities;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

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
        [ProducesResponseType(typeof(Telemetry[]), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get(string deviceId, [FromQuery] TimeSpan since)
        {
            var telemetry = await this.dbContext.Telemetries
                .Where(t => t.DeviceId == deviceId)
                .Where(t => t.Timestamp >= DateTime.UtcNow.Subtract(since))
                .ToListAsync();

            return this.Ok(telemetry);
        }
    }
}