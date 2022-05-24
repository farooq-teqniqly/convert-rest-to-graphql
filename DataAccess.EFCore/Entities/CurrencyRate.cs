// <copyright file="CurrencyRate.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Currency exchange rates.
    /// </summary>
    public sealed class CurrencyRate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyRate"/> class.
        /// </summary>
        public CurrencyRate()
        {
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        /// Gets or sets primary key for CurrencyRate records.
        /// </summary>
        public int CurrencyRateId { get; set; }

        /// <summary>
        /// Gets or sets date and time the exchange rate was obtained.
        /// </summary>
        public DateTime CurrencyRateDate { get; set; }

        /// <summary>
        /// Gets or sets exchange rate was converted from this currency code.
        /// </summary>
        public string FromCurrencyCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets exchange rate was converted to this currency code.
        /// </summary>
        public string ToCurrencyCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets average exchange rate for the day.
        /// </summary>
        public decimal AverageRate { get; set; }

        /// <summary>
        /// Gets or sets final exchange rate for the day.
        /// </summary>
        public decimal EndOfDayRate { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Currency FromCurrencyCodeNavigation { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Currency ToCurrencyCodeNavigation { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
