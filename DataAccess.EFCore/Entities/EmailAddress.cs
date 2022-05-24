// <copyright file="EmailAddress.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Where to send a person email.
    /// </summary>
    public class EmailAddress
    {
        /// <summary>
        /// Gets or sets primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets primary key. ID of this email address.
        /// </summary>
        public int EmailAddressId { get; set; }

        /// <summary>
        /// Gets or sets e-mail address for the person.
        /// </summary>
        public string EmailAddress1 { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Person BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
