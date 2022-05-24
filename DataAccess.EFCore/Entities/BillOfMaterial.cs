// <copyright file="BillOfMaterial.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Items required to make bicycles and bicycle subassemblies. It identifies the heirarchical relationship between a parent product and its components.
    /// </summary>
    public class BillOfMaterial
    {
        /// <summary>
        /// Gets or sets primary key for BillOfMaterials records.
        /// </summary>
        public int BillOfMaterialsId { get; set; }

        /// <summary>
        /// Gets or sets parent product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int? ProductAssemblyId { get; set; }

        /// <summary>
        /// Gets or sets component identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ComponentId { get; set; }

        /// <summary>
        /// Gets or sets date the component started being used in the assembly item.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date the component stopped being used in the assembly item.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets standard code identifying the unit of measure for the quantity.
        /// </summary>
        public string UnitMeasureCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets indicates the depth the component is from its parent (AssemblyID).
        /// </summary>
        public short Bomlevel { get; set; }

        /// <summary>
        /// Gets or sets quantity of the component needed to create the assembly.
        /// </summary>
        public decimal PerAssemblyQty { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Product Component { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Product? ProductAssembly { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual UnitMeasure UnitMeasureCodeNavigation { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
