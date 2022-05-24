// <copyright file="BusinessEntity.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Source of the ID that connects vendors, customers, and employees with address and contact information.
    /// </summary>
    public class BusinessEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessEntity"/> class.
        /// </summary>
        public BusinessEntity()
        {
            this.BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
            this.BusinessEntityContacts = new HashSet<BusinessEntityContact>();
        }

        /// <summary>
        /// Gets or sets primary key for all customers, vendors, and employees.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Person Person { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Store Store { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Vendor Vendor { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
