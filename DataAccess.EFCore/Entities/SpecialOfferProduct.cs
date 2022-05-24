// <copyright file="SpecialOfferProduct.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Cross-reference table mapping products to special offer discounts.
    /// </summary>
    public class SpecialOfferProduct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialOfferProduct"/> class.
        /// </summary>
        public SpecialOfferProduct()
        {
            this.SalesOrderDetails = new HashSet<SalesOrderDetail>();
        }

        /// <summary>
        /// Gets or sets primary key for SpecialOfferProduct records.
        /// </summary>
        public int SpecialOfferId { get; set; }

        /// <summary>
        /// Gets or sets product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Product Product { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual SpecialOffer SpecialOffer { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
