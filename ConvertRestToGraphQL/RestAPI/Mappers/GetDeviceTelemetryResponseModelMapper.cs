// <copyright file="GetDeviceTelemetryResponseModelMapper.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Mappers
{
    using AutoMapper;
    using DataAccess.EFCore.Entities;
    using RestAPI.Models;

    /// <summary>
    /// Maps a Telemetry entity to a GetDeviceTelemetryResponseModel instance.
    /// </summary>
    public class GetDeviceTelemetryResponseModelMapper : ITypeConverter<Telemetry, GetDeviceTelemetryResponseModel>
    {
        /// <inheritdoc/>
        public GetDeviceTelemetryResponseModel Convert(
            Telemetry source,
            GetDeviceTelemetryResponseModel destination,
            ResolutionContext context)
        {
            return new GetDeviceTelemetryResponseModel
            {
                TelemetryId = source.TelemetryId,
                Timestamp = source.Timestamp,
                Voltage = source.Voltage,
                Vibration = source.Vibration,
                Rotation = source.Rotation,
                Pressure = source.Pressure,
                DeviceStatus = source.DeviceStatus,
                IpAddress = source.IpAddress,
            };
        }
    }
}
