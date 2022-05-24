// <copyright file="ProductCostHistory.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Changes in the cost of a product over time.
    /// </summary>
    public class ProductCostHistory
    {
        /// <summary>
        /// Gets or sets product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets product cost start date.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets product cost end date.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets standard cost of the product.
        /// </summary>
        public decimal StandardCost { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Product Product { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
