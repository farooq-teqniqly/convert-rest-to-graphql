// <copyright file="TransactionHistoryArchive.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Transactions for previous years.
    /// </summary>
    public class TransactionHistoryArchive
    {
        /// <summary>
        /// Gets or sets primary key for TransactionHistoryArchive records.
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
        /// Gets or sets w = Work Order, S = Sales Order, P = Purchase Order.
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
    }
}
