// <copyright file="Product.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Products sold or used in the manfacturing of sold products.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
            this.BillOfMaterialComponents = new HashSet<BillOfMaterial>();
            this.BillOfMaterialProductAssemblies = new HashSet<BillOfMaterial>();
            this.ProductCostHistories = new HashSet<ProductCostHistory>();
            this.ProductInventories = new HashSet<ProductInventory>();
            this.ProductListPriceHistories = new HashSet<ProductListPriceHistory>();
            this.ProductProductPhotos = new HashSet<ProductProductPhoto>();
            this.ProductReviews = new HashSet<ProductReview>();
            this.ProductVendors = new HashSet<ProductVendor>();
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            this.ShoppingCartItems = new HashSet<ShoppingCartItem>();
            this.SpecialOfferProducts = new HashSet<SpecialOfferProduct>();
            this.TransactionHistories = new HashSet<TransactionHistory>();
            this.WorkOrders = new HashSet<WorkOrder>();
        }

        /// <summary>
        /// Gets or sets primary key for Product records.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets name of the product.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets unique product identification number.
        /// </summary>
        public string ProductNumber { get; set; } = null!;

        /// <summary>
        /// Gets or sets 0 = Product is purchased, 1 = Product is manufactured in-house.
        /// </summary>
        public bool? MakeFlag { get; set; }

        /// <summary>
        /// Gets or sets 0 = Product is not a salable item. 1 = Product is salable.
        /// </summary>
        public bool? FinishedGoodsFlag { get; set; }

        /// <summary>
        /// Gets or sets product color.
        /// </summary>
        public string? Color { get; set; }

        /// <summary>
        /// Gets or sets minimum inventory quantity.
        /// </summary>
        public short SafetyStockLevel { get; set; }

        /// <summary>
        /// Gets or sets inventory level that triggers a purchase order or work order.
        /// </summary>
        public short ReorderPoint { get; set; }

        /// <summary>
        /// Gets or sets standard cost of the product.
        /// </summary>
        public decimal StandardCost { get; set; }

        /// <summary>
        /// Gets or sets selling price.
        /// </summary>
        public decimal ListPrice { get; set; }

        /// <summary>
        /// Gets or sets product size.
        /// </summary>
        public string? Size { get; set; }

        /// <summary>
        /// Gets or sets unit of measure for Size column.
        /// </summary>
        public string? SizeUnitMeasureCode { get; set; }

        /// <summary>
        /// Gets or sets unit of measure for Weight column.
        /// </summary>
        public string? WeightUnitMeasureCode { get; set; }

        /// <summary>
        /// Gets or sets product weight.
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Gets or sets number of days required to manufacture the product.
        /// </summary>
        public int DaysToManufacture { get; set; }

        /// <summary>
        /// Gets or sets r = Road, M = Mountain, T = Touring, S = Standard.
        /// </summary>
        public string? ProductLine { get; set; }

        /// <summary>
        /// Gets or sets h = High, M = Medium, L = Low.
        /// </summary>
        public string? Class { get; set; }

        /// <summary>
        /// Gets or sets w = Womens, M = Mens, U = Universal.
        /// </summary>
        public string? Style { get; set; }

        /// <summary>
        /// Gets or sets product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID.
        /// </summary>
        public int? ProductSubcategoryId { get; set; }

        /// <summary>
        /// Gets or sets product is a member of this product model. Foreign key to ProductModel.ProductModelID.
        /// </summary>
        public int? ProductModelId { get; set; }

        /// <summary>
        /// Gets or sets date the product was available for sale.
        /// </summary>
        public DateTime SellStartDate { get; set; }

        /// <summary>
        /// Gets or sets date the product was no longer available for sale.
        /// </summary>
        public DateTime? SellEndDate { get; set; }

        /// <summary>
        /// Gets or sets date the product was discontinued.
        /// </summary>
        public DateTime? DiscontinuedDate { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ProductModel? ProductModel { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ProductSubcategory? ProductSubcategory { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual UnitMeasure? SizeUnitMeasureCodeNavigation { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual UnitMeasure? WeightUnitMeasureCodeNavigation { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<BillOfMaterial> BillOfMaterialComponents { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<BillOfMaterial> BillOfMaterialProductAssemblies { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
