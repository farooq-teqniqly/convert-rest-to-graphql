// <copyright file="DeviceController.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using AutoMapper;
    using DataAccess.EFCore;
    using DataAccess.EFCore.Entities;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using RestAPI.Models;

    /// <summary>
    /// Endpoints for querying and updating devices.
    /// </summary>
    [ApiController]
    [Route("api/devices")]
    public class DeviceController : ControllerBase
    {
        private readonly TelemetryDbContext dbContext;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceController"/> class.
        /// </summary>
        /// <param name="dbContext">The EF Core database context.</param>
        /// <param name="mapper">The model/entity mapper.</param>
        public DeviceController(TelemetryDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        /// <summary>
        /// Gets the device with the specified id.
        /// </summary>
        /// <param name="deviceId">The device id.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpGet("{deviceId}")]
        [ProducesResponseType(typeof(ResponseEnvelopeModel<GetDeviceResponseModel>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetDevice(string deviceId)
        {
            var device = await this.dbContext.Devices.SingleOrDefaultAsync(d => d.DeviceId == deviceId);

            if (device == null)
            {
                return this.NotFound();
            }

            return this.Ok(new ResponseEnvelopeModel<GetDeviceResponseModel>
            {
                Count = 1,
                Data = new List<GetDeviceResponseModel>
                {
                    this.mapper.Map<Device, GetDeviceResponseModel>(device),
                },
            });
        }

        /// <summary>
        /// Gets all devices.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(ResponseEnvelopeModel<GetDevicesResponseModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetDevices()
        {
            var devices = await this.dbContext.Devices
                .Select(d => this.mapper.Map<Device, GetDevicesResponseModel>(d))
                .ToListAsync();

            return this.Ok(new ResponseEnvelopeModel<GetDevicesResponseModel> { Count = devices.Count, Data = devices });
        }

        /// <summary>
        /// Updates the device with the specified id.
        /// </summary>
        /// <param name="deviceId">The device id.</param>
        /// <param name="model">The update model.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpPut("{deviceId}")]
        [ProducesResponseType(typeof(ResponseEnvelopeModel<UpdateDeviceResponseModel>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateDevice(string deviceId, UpdateDeviceModel model)
        {
            var device = this.dbContext.Devices.SingleOrDefault(d => d.DeviceId == deviceId);

            if (device == null)
            {
                return this.NotFound();
            }

            device = this.mapper.Map<UpdateDeviceModel, Device>(model);
            device.DeviceId = deviceId;
            this.dbContext.Devices.Update(device);
            await this.dbContext.SaveChangesAsync();

            var responseModel = this.mapper.Map<Device, UpdateDeviceResponseModel>(device);

            return this.Ok(new ResponseEnvelopeModel<UpdateDeviceResponseModel> { Count = 1, Data = new List<UpdateDeviceResponseModel> { responseModel } });
        }
    }
}
