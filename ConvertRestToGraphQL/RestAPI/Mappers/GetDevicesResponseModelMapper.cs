// <copyright file="GetDevicesResponseModelMapper.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Mappers
{
    using AutoMapper;
    using DataAccess.EFCore.Entities;
    using RestAPI.Models;

    /// <summary>
    /// Maps a Device entity to a GetDevicesResponseModel instance.
    /// </summary>
    public class GetDevicesResponseModelMapper : ITypeConverter<Device, GetDevicesResponseModel>
    {
        /// <inheritdoc/>
        public GetDevicesResponseModel Convert(
            Device source,
            GetDevicesResponseModel destination,
            ResolutionContext context)
        {
            return new GetDevicesResponseModel
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