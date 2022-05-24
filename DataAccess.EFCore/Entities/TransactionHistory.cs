// <copyright file="TransactionHistory.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Record of each purchase order, sales order, or work order transaction year to date.
    /// </summary>
    public class TransactionHistory
    {
        /// <summary>
        /// Gets or sets primary key for TransactionHistory records.
        /// </summary>
        public int TransactionId { get; set; }

        /// <summary>
        /// Gets or sets product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets purchase order, sales order, or work order identification number.
        /// </summary>
        public int ReferenceOrderId { get; set; }

        /// <summary>
        /// Gets or sets line number associated with the purchase order, sales order, or work order.
        /// </summary>
        public int ReferenceOrderLineId { get; set; }

        /// <summary>
        /// Gets or sets date and time of the transaction.
        /// </summary>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Gets or sets w = WorkOrder, S = SalesOrder, P = PurchaseOrder.
        /// </summary>
        public string TransactionType { get; set; } = null!;

        /// <summary>
        /// Gets or sets product quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets product cost.
        /// </summary>
        public decimal ActualCost { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Product Product { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
