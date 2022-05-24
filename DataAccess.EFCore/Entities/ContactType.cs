// <copyright file="ContactType.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Lookup table containing the types of business entity contacts.
    /// </summary>
    public class ContactType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactType"/> class.
        /// </summary>
        public ContactType()
        {
            this.BusinessEntityContacts = new HashSet<BusinessEntityContact>();
        }

        /// <summary>
        /// Gets or sets primary key for ContactType records.
        /// </summary>
        public int ContactTypeId { get; set; }

        /// <summary>
        /// Gets or sets contact type description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
