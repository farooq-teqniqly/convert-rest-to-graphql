// <copyright file="ProductProductPhoto.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Cross-reference table mapping products and product photos.
    /// </summary>
    public class ProductProductPhoto
    {
        /// <summary>
        /// Gets or sets product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.
        /// </summary>
        public int ProductPhotoId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 0 = Photo is not the principal image. 1 = Photo is the principal image.
        /// </summary>
        public bool Primary { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Product Product { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ProductPhoto ProductPhoto { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
