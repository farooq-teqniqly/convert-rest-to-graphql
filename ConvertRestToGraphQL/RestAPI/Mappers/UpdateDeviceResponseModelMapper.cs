// <copyright file="UpdateDeviceResponseModelMapper.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Mappers
{
    using AutoMapper;
    using DataAccess.EFCore.Entities;
    using RestAPI.Models;

    /// <summary>
    /// Converts a Device entity to an UpdateDeviceResponseModel instance.
    /// </summary>
    public class UpdateDeviceResponseModelMapper : ITypeConverter<Device, UpdateDeviceResponseModel>
    {
        /// <inheritdoc/>
        public UpdateDeviceResponseModel Convert(
            Device source,
            UpdateDeviceResponseModel destination,
            ResolutionContext context)
        {
            return new UpdateDeviceResponseModel
            {
                DeviceId = source.DeviceId,
                Description = source.Description,
                Department = source.Department,
                DateAcquired = source.DateAcquired,
                FirmwareVersion = source.FirmwareVersion,
            };
        }
    }
}