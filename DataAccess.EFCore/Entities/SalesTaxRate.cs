// <copyright file="SalesTaxRate.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Tax rate lookup table.
    /// </summary>
    public class SalesTaxRate
    {
        /// <summary>
        /// Gets or sets primary key for SalesTaxRate records.
        /// </summary>
        public int SalesTaxRateId { get; set; }

        /// <summary>
        /// Gets or sets state, province, or country/region the sales tax applies to.
        /// </summary>
        public int StateProvinceId { get; set; }

        /// <summary>
        /// Gets or sets 1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions.
        /// </summary>
        public byte TaxType { get; set; }

        /// <summary>
        /// Gets or sets tax rate amount.
        /// </summary>
        public decimal TaxRate { get; set; }

        /// <summary>
        /// Gets or sets tax rate description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual StateProvince StateProvince { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
