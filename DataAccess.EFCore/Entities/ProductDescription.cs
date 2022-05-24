// <copyright file="ProductDescription.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Product descriptions in several languages.
    /// </summary>
    public class ProductDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDescription"/> class.
        /// </summary>
        public ProductDescription()
        {
            this.ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        }

        /// <summary>
        /// Gets or sets primary key for ProductDescription records.
        /// </summary>
        public int ProductDescriptionId { get; set; }

        /// <summary>
        /// Gets or sets description of the product.
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
