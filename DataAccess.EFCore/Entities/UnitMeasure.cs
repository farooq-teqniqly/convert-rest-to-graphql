// <copyright file="UnitMeasure.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Unit of measure lookup table.
    /// </summary>
    public class UnitMeasure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitMeasure"/> class.
        /// </summary>
        public UnitMeasure()
        {
            this.BillOfMaterials = new HashSet<BillOfMaterial>();
            this.ProductSizeUnitMeasureCodeNavigations = new HashSet<Product>();
            this.ProductVendors = new HashSet<ProductVendor>();
            this.ProductWeightUnitMeasureCodeNavigations = new HashSet<Product>();
        }

        /// <summary>
        /// Gets or sets primary key.
        /// </summary>
        public string UnitMeasureCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets unit of measure description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<Product> ProductSizeUnitMeasureCodeNavigations { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<Product> ProductWeightUnitMeasureCodeNavigations { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
