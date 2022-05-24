// <copyright file="ProductCategory.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// High-level product categorization.
    /// </summary>
    public sealed class ProductCategory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCategory"/> class.
        /// </summary>
        public ProductCategory()
        {
            this.ProductSubcategories = new HashSet<ProductSubcategory>();
        }

        /// <summary>
        /// Gets or sets primary key for ProductCategory records.
        /// </summary>
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// Gets or sets category description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<ProductSubcategory> ProductSubcategories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
