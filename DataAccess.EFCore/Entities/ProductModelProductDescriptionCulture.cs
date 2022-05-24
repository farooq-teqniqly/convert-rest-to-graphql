// <copyright file="ProductModelProductDescriptionCulture.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Cross-reference table mapping product descriptions and the language the description is written in.
    /// </summary>
    public class ProductModelProductDescriptionCulture
    {
        /// <summary>
        /// Gets or sets primary key. Foreign key to ProductModel.ProductModelID.
        /// </summary>
        public int ProductModelId { get; set; }

        /// <summary>
        /// Gets or sets primary key. Foreign key to ProductDescription.ProductDescriptionID.
        /// </summary>
        public int ProductDescriptionId { get; set; }

        /// <summary>
        /// Gets or sets culture identification number. Foreign key to Culture.CultureID.
        /// </summary>
        public string CultureId { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Culture Culture { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ProductDescription ProductDescription { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ProductModel ProductModel { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
