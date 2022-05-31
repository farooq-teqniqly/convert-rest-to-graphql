// <copyright file="DeviceMutation.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.Graph.Mutations
{
    using DataAccess.EFCore;
    using DataAccess.EFCore.Entities;
    using DataAccess.Graph.Types;
    using GraphQL;
    using GraphQL.Types;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Device mutation.
    /// </summary>
    public class DeviceMutation : ObjectGraphType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMutation"/> class.
        /// </summary>
        /// <param name="dbContext">The EF Core database context.</param>
        public DeviceMutation(TelemetryDbContext dbContext)
        {
            this.FieldAsync<DeviceType>(
                "updatedDevice",
                "Updated device metadata.",
                new QueryArguments(new QueryArgument<NonNullGraphType<UpdateDeviceInputType>>
                {
                    Name = "updateDeviceInput",
                }),
                resolve: async ctx =>
                {
                    var deviceArg = ctx.GetArgument<Device>("updateDeviceInput");
                    var deviceToUpdate = await dbContext.Devices.SingleOrDefaultAsync(d => d.DeviceId == deviceArg.DeviceId);

                    if (deviceToUpdate == null)
                    {
                        throw new ExecutionError("The specified device id does not exist.");
                    }

                    deviceToUpdate.DateAcquired = deviceArg.DateAcquired;
                    deviceToUpdate.Department = deviceArg.Department;
                    deviceToUpdate.Description = deviceArg.Description;
                    deviceToUpdate.FirmwareVersion = deviceArg.FirmwareVersion;

                    dbContext.Devices.Update(deviceToUpdate);
                    await dbContext.SaveChangesAsync();

                    return deviceArg;
                });
        }
    }
}
