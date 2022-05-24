// <copyright file="StateProvince.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// State and province lookup table.
    /// </summary>
    public sealed class StateProvince
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateProvince"/> class.
        /// </summary>
        public StateProvince()
        {
            this.Addresses = new HashSet<Address>();
            this.SalesTaxRates = new HashSet<SalesTaxRate>();
        }

        /// <summary>
        /// Gets or sets primary key for StateProvince records.
        /// </summary>
        public int StateProvinceId { get; set; }

        /// <summary>
        /// Gets or sets iSO standard state or province code.
        /// </summary>
        public string StateProvinceCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets iSO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        /// </summary>
        public string CountryRegionCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets 0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.
        /// </summary>
        public bool? IsOnlyStateProvinceFlag { get; set; }

        /// <summary>
        /// Gets or sets state or province description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets iD of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.
        /// </summary>
        public int TerritoryId { get; set; }

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
        public SalesTerritory Territory { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<Address> Addresses { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<SalesTaxRate> SalesTaxRates { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
