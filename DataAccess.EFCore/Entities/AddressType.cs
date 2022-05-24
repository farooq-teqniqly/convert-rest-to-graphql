// <copyright file="AddressType.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Types of addresses stored in the Address table.
    /// </summary>
    public class AddressType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressType"/> class.
        /// </summary>
        public AddressType()
        {
            this.BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
        }

        /// <summary>
        /// Gets or sets primary key for AddressType records.
        /// </summary>
        public int AddressTypeId { get; set; }

        /// <summary>
        /// Gets or sets address type description. For example, Billing, Home, or Shipping.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
