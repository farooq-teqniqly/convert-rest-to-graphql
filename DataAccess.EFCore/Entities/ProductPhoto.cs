// <copyright file="ProductPhoto.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Product images.
    /// </summary>
    public class ProductPhoto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPhoto"/> class.
        /// </summary>
        public ProductPhoto()
        {
            this.ProductProductPhotos = new HashSet<ProductProductPhoto>();
        }

        /// <summary>
        /// Gets or sets primary key for ProductPhoto records.
        /// </summary>
        public int ProductPhotoId { get; set; }

        /// <summary>
        /// Gets or sets small image of the product.
        /// </summary>
#pragma warning disable SA1011 // Closing square brackets should be spaced correctly
        public byte[] ThumbNailPhoto { get; set; }
#pragma warning restore SA1011 // Closing square brackets should be spaced correctly

        /// <summary>
        /// Gets or sets small image file name.
        /// </summary>
        public string ThumbnailPhotoFileName { get; set; }

        /// <summary>
        /// Gets or sets large image of the product.
        /// </summary>
#pragma warning disable SA1011 // Closing square brackets should be spaced correctly
        public byte[] LargePhoto { get; set; }
#pragma warning restore SA1011 // Closing square brackets should be spaced correctly

        /// <summary>
        /// Gets or sets large image file name.
        /// </summary>
        public string LargePhotoFileName { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
