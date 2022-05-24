// <copyright file="ProductVendor.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Cross-reference table mapping vendors with the products they supply.
    /// </summary>
    public class ProductVendor
    {
        /// <summary>
        /// Gets or sets primary key. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets primary key. Foreign key to Vendor.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets the average span of time (in days) between placing an order with the vendor and receiving the purchased product.
        /// </summary>
        public int AverageLeadTime { get; set; }

        /// <summary>
        /// Gets or sets the vendor&apos;s usual selling price.
        /// </summary>
        public decimal StandardPrice { get; set; }

        /// <summary>
        /// Gets or sets the selling price when last purchased.
        /// </summary>
        public decimal? LastReceiptCost { get; set; }

        /// <summary>
        /// Gets or sets date the product was last received by the vendor.
        /// </summary>
        public DateTime? LastReceiptDate { get; set; }

        /// <summary>
        /// Gets or sets the maximum quantity that should be ordered.
        /// </summary>
        public int MinOrderQty { get; set; }

        /// <summary>
        /// Gets or sets the minimum quantity that should be ordered.
        /// </summary>
        public int MaxOrderQty { get; set; }

        /// <summary>
        /// Gets or sets the quantity currently on order.
        /// </summary>
        public int? OnOrderQty { get; set; }

        /// <summary>
        /// Gets or sets the product&apos;s unit of measure.
        /// </summary>
        public string UnitMeasureCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Vendor BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Product Product { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual UnitMeasure UnitMeasureCodeNavigation { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
