// <copyright file="ProductModel.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Product model classification.
    /// </summary>
    public sealed class ProductModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModel"/> class.
        /// </summary>
        public ProductModel()
        {
            this.ProductModelIllustrations = new HashSet<ProductModelIllustration>();
            this.ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
            this.Products = new HashSet<Product>();
        }

        /// <summary>
        /// Gets or sets primary key for ProductModel records.
        /// </summary>
        public int ProductModelId { get; set; }

        /// <summary>
        /// Gets or sets product model description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets detailed product catalog information in xml format.
        /// </summary>
        public string CatalogDescription { get; set; }

        /// <summary>
        /// Gets or sets manufacturing instructions in xml format.
        /// </summary>
        public string Instructions { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<Product> Products { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
