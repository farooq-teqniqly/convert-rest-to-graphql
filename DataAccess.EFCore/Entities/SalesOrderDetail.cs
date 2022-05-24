// <copyright file="SalesOrderDetail.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Individual products associated with a specific sales order. See SalesOrderHeader.
    /// </summary>
    public class SalesOrderDetail
    {
        /// <summary>
        /// Gets or sets primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        /// </summary>
        public int SalesOrderId { get; set; }

        /// <summary>
        /// Gets or sets primary key. One incremental unique number per product sold.
        /// </summary>
        public int SalesOrderDetailId { get; set; }

        /// <summary>
        /// Gets or sets shipment tracking number supplied by the shipper.
        /// </summary>
        public string? CarrierTrackingNumber { get; set; }

        /// <summary>
        /// Gets or sets quantity ordered per product.
        /// </summary>
        public short OrderQty { get; set; }

        /// <summary>
        /// Gets or sets product sold to customer. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets promotional code. Foreign key to SpecialOffer.SpecialOfferID.
        /// </summary>
        public int SpecialOfferId { get; set; }

        /// <summary>
        /// Gets or sets selling price of a single product.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets discount amount.
        /// </summary>
        public decimal UnitPriceDiscount { get; set; }

        /// <summary>
        /// Gets or sets per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.
        /// </summary>
        public decimal LineTotal { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual SalesOrderHeader SalesOrder { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
