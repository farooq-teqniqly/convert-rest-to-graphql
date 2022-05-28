// <copyright file="GetDeviceResponseModelMapper.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Mappers
{
    using AutoMapper;
    using DataAccess.EFCore.Entities;
    using RestAPI.Models;

    /// <summary>
    /// Maps a Device entity to a GetDeviceResponseModel.
    /// </summary>
    public class GetDeviceResponseModelMapper : ITypeConverter<Device, GetDeviceResponseModel>
    {
        /// <inheritdoc/>
        public GetDeviceResponseModel Convert(Device source, GetDeviceResponseModel destination, ResolutionContext context)
        {
            return new GetDeviceResponseModel
            {
                Description = source.Description,
                Department = source.Department,
                DateAcquired = source.DateAcquired,
                FirmwareVersion = source.FirmwareVersion,
            };
        }
    }
}