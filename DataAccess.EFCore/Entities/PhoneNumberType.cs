// <copyright file="PhoneNumberType.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Type of phone number of a person.
    /// </summary>
    public class PhoneNumberType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberType"/> class.
        /// </summary>
        public PhoneNumberType()
        {
            this.PersonPhones = new HashSet<PersonPhone>();
        }

        /// <summary>
        /// Gets or sets primary key for telephone number type records.
        /// </summary>
        public int PhoneNumberTypeId { get; set; }

        /// <summary>
        /// Gets or sets name of the telephone number type.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
