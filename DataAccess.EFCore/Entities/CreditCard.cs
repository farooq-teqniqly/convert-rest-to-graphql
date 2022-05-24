// <copyright file="CreditCard.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Customer credit card information.
    /// </summary>
    public sealed class CreditCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCard"/> class.
        /// </summary>
        public CreditCard()
        {
            this.PersonCreditCards = new HashSet<PersonCreditCard>();
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        /// Gets or sets primary key for CreditCard records.
        /// </summary>
        public int CreditCardId { get; set; }

        /// <summary>
        /// Gets or sets credit card name.
        /// </summary>
        public string CardType { get; set; } = null!;

        /// <summary>
        /// Gets or sets credit card number.
        /// </summary>
        public string CardNumber { get; set; } = null!;

        /// <summary>
        /// Gets or sets credit card expiration month.
        /// </summary>
        public byte ExpMonth { get; set; }

        /// <summary>
        /// Gets or sets credit card expiration year.
        /// </summary>
        public short ExpYear { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<PersonCreditCard> PersonCreditCards { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
