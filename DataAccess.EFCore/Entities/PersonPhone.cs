// <copyright file="PersonPhone.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Telephone number and type of a person.
    /// </summary>
    public class PersonPhone
    {
        /// <summary>
        /// Gets or sets business entity identification number. Foreign key to Person.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets telephone number identification number.
        /// </summary>
        public string PhoneNumber { get; set; } = null!;

        /// <summary>
        /// Gets or sets kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.
        /// </summary>
        public int PhoneNumberTypeId { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Person BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual PhoneNumberType PhoneNumberType { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
