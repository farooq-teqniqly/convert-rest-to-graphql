// <copyright file="SalesPersonQuotaHistory.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Sales performance tracking.
    /// </summary>
    public class SalesPersonQuotaHistory
    {
        /// <summary>
        /// Gets or sets sales person identification number. Foreign key to SalesPerson.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets sales quota date.
        /// </summary>
        public DateTime QuotaDate { get; set; }

        /// <summary>
        /// Gets or sets sales quota amount.
        /// </summary>
        public decimal SalesQuota { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual SalesPerson BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
