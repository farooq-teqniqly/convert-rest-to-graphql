// <copyright file="PurchaseOrderDetail.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Individual products associated with a specific purchase order. See PurchaseOrderHeader.
    /// </summary>
    public class PurchaseOrderDetail
    {
        /// <summary>
        /// Gets or sets primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.
        /// </summary>
        public int PurchaseOrderId { get; set; }

        /// <summary>
        /// Gets or sets primary key. One line number per purchased product.
        /// </summary>
        public int PurchaseOrderDetailId { get; set; }

        /// <summary>
        /// Gets or sets date the product is expected to be received.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets quantity ordered.
        /// </summary>
        public short OrderQty { get; set; }

        /// <summary>
        /// Gets or sets product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets vendor&apos;s selling price of a single product.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets per product subtotal. Computed as OrderQty * UnitPrice.
        /// </summary>
        public decimal LineTotal { get; set; }

        /// <summary>
        /// Gets or sets quantity actually received from the vendor.
        /// </summary>
        public decimal ReceivedQty { get; set; }

        /// <summary>
        /// Gets or sets quantity rejected during inspection.
        /// </summary>
        public decimal RejectedQty { get; set; }

        /// <summary>
        /// Gets or sets quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.
        /// </summary>
        public decimal StockedQty { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Product Product { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual PurchaseOrderHeader PurchaseOrder { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
