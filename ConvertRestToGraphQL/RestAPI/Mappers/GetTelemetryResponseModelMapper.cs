// <copyright file="GetTelemetryResponseModelMapper.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Mappers
{
    using AutoMapper;
    using DataAccess.EFCore.Entities;
    using RestAPI.Models;

    /// <summary>
    /// Maps a Telemetry entity to a GetTelemetryResponseModel instance.
    /// </summary>
    public class GetTelemetryResponseModelMapper : ITypeConverter<Telemetry, GetTelemetryResponseModel>
    {
        /// <inheritdoc/>
        public GetTelemetryResponseModel Convert(
            Telemetry source,
            GetTelemetryResponseModel destination,
            ResolutionContext context)
        {
            return new GetTelemetryResponseModel
            {
                TelemetryId = source.TelemetryId,
                DeviceId = source.DeviceId,
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