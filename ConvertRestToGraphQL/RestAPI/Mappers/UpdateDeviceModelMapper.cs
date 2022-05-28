// <copyright file="UpdateDeviceModelMapper.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Mappers
{
    using AutoMapper;
    using DataAccess.EFCore.Entities;
    using RestAPI.Models;

    /// <summary>
    /// Maps an UpdateDeviceModel instance to a Device entity.
    /// </summary>
    public class UpdateDeviceModelMapper : ITypeConverter<UpdateDeviceModel, Device>
    {
        /// <inheritdoc/>
        public Device Convert(UpdateDeviceModel source, Device destination, ResolutionContext context)
        {
            return new Device
            {
                Department = source.Department,
                Description = source.Description,
                DateAcquired = source.DateAcquired,
                FirmwareVersion = source.FirmwareVersion,
            };
        }
    }
}