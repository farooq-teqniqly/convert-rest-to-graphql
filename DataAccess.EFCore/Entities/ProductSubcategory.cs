// <copyright file="ProductSubcategory.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Product subcategories. See ProductCategory table.
    /// </summary>
    public sealed class ProductSubcategory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubcategory"/> class.
        /// </summary>
        public ProductSubcategory()
        {
            this.Products = new HashSet<Product>();
        }

        /// <summary>
        /// Gets or sets primary key for ProductSubcategory records.
        /// </summary>
        public int ProductSubcategoryId { get; set; }

        /// <summary>
        /// Gets or sets product category identification number. Foreign key to ProductCategory.ProductCategoryID.
        /// </summary>
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// Gets or sets subcategory description.
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
        public ProductCategory ProductCategory { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<Product> Products { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
