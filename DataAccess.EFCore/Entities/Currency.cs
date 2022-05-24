// <copyright file="Currency.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Lookup table containing standard ISO currencies.
    /// </summary>
    public sealed class Currency
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Currency"/> class.
        /// </summary>
        public Currency()
        {
            this.CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
            this.CurrencyRateFromCurrencyCodeNavigations = new HashSet<CurrencyRate>();
            this.CurrencyRateToCurrencyCodeNavigations = new HashSet<CurrencyRate>();
        }

        /// <summary>
        /// Gets or sets the ISO code for the Currency.
        /// </summary>
        public string CurrencyCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets currency name.
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
        public ICollection<CurrencyRate> CurrencyRateFromCurrencyCodeNavigations { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<CurrencyRate> CurrencyRateToCurrencyCodeNavigations { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
