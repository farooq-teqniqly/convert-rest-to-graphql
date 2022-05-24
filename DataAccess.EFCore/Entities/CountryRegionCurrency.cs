// <copyright file="CountryRegionCurrency.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Cross-reference table mapping ISO currency codes to a country or region.
    /// </summary>
    public class CountryRegionCurrency
    {
        /// <summary>
        /// Gets or sets iSO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.
        /// </summary>
        public string CountryRegionCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets iSO standard currency code. Foreign key to Currency.CurrencyCode.
        /// </summary>
        public string CurrencyCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual CountryRegion CountryRegionCodeNavigation { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Currency CurrencyCodeNavigation { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
