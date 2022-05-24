// <copyright file="Vendor.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Companies from whom Adventure Works Cycles purchases parts or other goods.
    /// </summary>
    public sealed class Vendor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vendor"/> class.
        /// </summary>
        public Vendor()
        {
            this.ProductVendors = new HashSet<ProductVendor>();
            this.PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
        }

        /// <summary>
        /// Gets or sets primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets vendor account (identification) number.
        /// </summary>
        public string AccountNumber { get; set; } = null!;

        /// <summary>
        /// Gets or sets company name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets 1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average.
        /// </summary>
        public byte CreditRating { get; set; }

        /// <summary>
        /// Gets or sets 0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.
        /// </summary>
        public bool? PreferredVendorStatus { get; set; }

        /// <summary>
        /// Gets or sets 0 = Vendor no longer used. 1 = Vendor is actively used.
        /// </summary>
        public bool? ActiveFlag { get; set; }

        /// <summary>
        /// Gets or sets vendor URL.
        /// </summary>
        public string PurchasingWebServiceUrl { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public BusinessEntity BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<ProductVendor> ProductVendors { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
