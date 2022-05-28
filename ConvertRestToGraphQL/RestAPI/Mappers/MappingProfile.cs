// <copyright file="MappingProfile.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Mappers
{
    using AutoMapper;
    using DataAccess.EFCore.Entities;
    using RestAPI.Models;

    /// <summary>
    /// The AutoMapper mapping profile.
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingProfile"/> class.
        /// </summary>
        public MappingProfile()
        {
            this.CreateMap<Telemetry, GetDeviceTelemetryResponseModel>().ConvertUsing<GetDeviceTelemetryResponseModelMapper>();
            this.CreateMap<Telemetry, GetTelemetryResponseModel>().ConvertUsing<GetTelemetryResponseModelMapper>();
            this.CreateMap<Device, GetDeviceResponseModel>().ConvertUsing<GetDeviceResponseModelMapper>();
            this.CreateMap<Device, GetDevicesResponseModel>().ConvertUsing<GetDevicesResponseModelMapper>();
            this.CreateMap<UpdateDeviceModel, Device>().ConvertUsing<UpdateDeviceModelMapper>();
            this.CreateMap<Device, UpdateDeviceResponseModel>().ConvertUsing<UpdateDeviceResponseModelMapper>();
        }
    }
}