// <copyright file="SalesOrderHeaderSalesReason.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Cross-reference table mapping sales orders to sales reason codes.
    /// </summary>
    public class SalesOrderHeaderSalesReason
    {
        /// <summary>
        /// Gets or sets primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        /// </summary>
        public int SalesOrderId { get; set; }

        /// <summary>
        /// Gets or sets primary key. Foreign key to SalesReason.SalesReasonID.
        /// </summary>
        public int SalesReasonId { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual SalesOrderHeader SalesOrder { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual SalesReason SalesReason { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
