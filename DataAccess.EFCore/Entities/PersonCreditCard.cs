// <copyright file="PersonCreditCard.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Cross-reference table mapping people to their credit card information in the CreditCard table.
    /// </summary>
    public class PersonCreditCard
    {
        /// <summary>
        /// Gets or sets business entity identification number. Foreign key to Person.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets credit card identification number. Foreign key to CreditCard.CreditCardID.
        /// </summary>
        public int CreditCardId { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Person BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual CreditCard CreditCard { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
