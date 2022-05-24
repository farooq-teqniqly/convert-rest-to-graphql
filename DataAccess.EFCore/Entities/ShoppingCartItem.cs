// <copyright file="ShoppingCartItem.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Contains online customer orders until the order is submitted or cancelled.
    /// </summary>
    public class ShoppingCartItem
    {
        /// <summary>
        /// Gets or sets primary key for ShoppingCartItem records.
        /// </summary>
        public int ShoppingCartItemId { get; set; }

        /// <summary>
        /// Gets or sets shopping cart identification number.
        /// </summary>
        public string ShoppingCartId { get; set; } = null!;

        /// <summary>
        /// Gets or sets product quantity ordered.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets product ordered. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets date the time the record was created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Product Product { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
