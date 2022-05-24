// <copyright file="SalesReason.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Lookup table of customer purchase reasons.
    /// </summary>
    public sealed class SalesReason
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesReason"/> class.
        /// </summary>
        public SalesReason()
        {
            this.SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();
        }

        /// <summary>
        /// Gets or sets primary key for SalesReason records.
        /// </summary>
        public int SalesReasonId { get; set; }

        /// <summary>
        /// Gets or sets sales reason description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets category the sales reason belongs to.
        /// </summary>
        public string ReasonType { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
