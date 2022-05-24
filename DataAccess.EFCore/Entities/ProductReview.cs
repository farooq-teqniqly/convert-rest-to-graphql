// <copyright file="ProductReview.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Customer reviews of products they have purchased.
    /// </summary>
    public class ProductReview
    {
        /// <summary>
        /// Gets or sets primary key for ProductReview records.
        /// </summary>
        public int ProductReviewId { get; set; }

        /// <summary>
        /// Gets or sets product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets name of the reviewer.
        /// </summary>
        public string ReviewerName { get; set; } = null!;

        /// <summary>
        /// Gets or sets date review was submitted.
        /// </summary>
        public DateTime ReviewDate { get; set; }

        /// <summary>
        /// Gets or sets reviewer&apos;s e-mail address.
        /// </summary>
        public string EmailAddress { get; set; } = null!;

        /// <summary>
        /// Gets or sets product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets reviewer&apos;s comments.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Product Product { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
