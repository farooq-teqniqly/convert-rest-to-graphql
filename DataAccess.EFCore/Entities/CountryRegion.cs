// <copyright file="CountryRegion.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Lookup table containing the ISO standard codes for countries and regions.
    /// </summary>
    public sealed class CountryRegion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryRegion"/> class.
        /// </summary>
        public CountryRegion()
        {
            this.CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
            this.SalesTerritories = new HashSet<SalesTerritory>();
            this.StateProvinces = new HashSet<StateProvince>();
        }

        /// <summary>
        /// Gets or sets iSO standard code for countries and regions.
        /// </summary>
        public string CountryRegionCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets country or region name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<SalesTerritory> SalesTerritories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<StateProvince> StateProvinces { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
