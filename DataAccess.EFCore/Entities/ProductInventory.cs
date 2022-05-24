// <copyright file="ProductInventory.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Product inventory information.
    /// </summary>
    public class ProductInventory
    {
        /// <summary>
        /// Gets or sets product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets inventory location identification number. Foreign key to Location.LocationID.
        /// </summary>
        public short LocationId { get; set; }

        /// <summary>
        /// Gets or sets storage compartment within an inventory location.
        /// </summary>
        public string Shelf { get; set; } = null!;

        /// <summary>
        /// Gets or sets storage container on a shelf in an inventory location.
        /// </summary>
        public byte Bin { get; set; }

        /// <summary>
        /// Gets or sets quantity of products in the inventory location.
        /// </summary>
        public short Quantity { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Location Location { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Product Product { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
