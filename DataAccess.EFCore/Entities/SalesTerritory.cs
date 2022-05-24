// <copyright file="SalesTerritory.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Sales territory lookup table.
    /// </summary>
    public sealed class SalesTerritory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesTerritory"/> class.
        /// </summary>
        public SalesTerritory()
        {
            this.Customers = new HashSet<Customer>();
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            this.SalesPeople = new HashSet<SalesPerson>();
            this.SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
            this.StateProvinces = new HashSet<StateProvince>();
        }

        /// <summary>
        /// Gets or sets primary key for SalesTerritory records.
        /// </summary>
        public int TerritoryId { get; set; }

        /// <summary>
        /// Gets or sets sales territory description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets iSO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        /// </summary>
        public string CountryRegionCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets geographic area to which the sales territory belong.
        /// </summary>
        public string Group { get; set; } = null!;

        /// <summary>
        /// Gets or sets sales in the territory year to date.
        /// </summary>
        public decimal SalesYtd { get; set; }

        /// <summary>
        /// Gets or sets sales in the territory the previous year.
        /// </summary>
        public decimal SalesLastYear { get; set; }

        /// <summary>
        /// Gets or sets business costs in the territory year to date.
        /// </summary>
        public decimal CostYtd { get; set; }

        /// <summary>
        /// Gets or sets business costs in the territory the previous year.
        /// </summary>
        public decimal CostLastYear { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public CountryRegion CountryRegionCodeNavigation { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<Customer> Customers { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<SalesPerson> SalesPeople { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<StateProvince> StateProvinces { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
