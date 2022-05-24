// <copyright file="SpecialOffer.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Sale discounts lookup table.
    /// </summary>
    public sealed class SpecialOffer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialOffer"/> class.
        /// </summary>
        public SpecialOffer()
        {
            this.SpecialOfferProducts = new HashSet<SpecialOfferProduct>();
        }

        /// <summary>
        /// Gets or sets primary key for SpecialOffer records.
        /// </summary>
        public int SpecialOfferId { get; set; }

        /// <summary>
        /// Gets or sets discount description.
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// Gets or sets discount precentage.
        /// </summary>
        public decimal DiscountPct { get; set; }

        /// <summary>
        /// Gets or sets discount type category.
        /// </summary>
        public string Type { get; set; } = null!;

        /// <summary>
        /// Gets or sets group the discount applies to such as Reseller or Customer.
        /// </summary>
        public string Category { get; set; } = null!;

        /// <summary>
        /// Gets or sets discount start date.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets discount end date.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets minimum discount percent allowed.
        /// </summary>
        public int MinQty { get; set; }

        /// <summary>
        /// Gets or sets maximum discount percent allowed.
        /// </summary>
        public int? MaxQty { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
