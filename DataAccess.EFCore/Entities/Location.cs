// <copyright file="Location.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Product inventory and manufacturing locations.
    /// </summary>
    public sealed class Location
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        public Location()
        {
            this.ProductInventories = new HashSet<ProductInventory>();
            this.WorkOrderRoutings = new HashSet<WorkOrderRouting>();
        }

        /// <summary>
        /// Gets or sets primary key for Location records.
        /// </summary>
        public short LocationId { get; set; }

        /// <summary>
        /// Gets or sets location description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets standard hourly cost of the manufacturing location.
        /// </summary>
        public decimal CostRate { get; set; }

        /// <summary>
        /// Gets or sets work capacity (in hours) of the manufacturing location.
        /// </summary>
        public decimal Availability { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<ProductInventory> ProductInventories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
