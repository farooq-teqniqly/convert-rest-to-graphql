// <copyright file="BusinessEntityAddress.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Cross-reference table mapping customers, vendors, and employees to their addresses.
    /// </summary>
    public class BusinessEntityAddress
    {
        /// <summary>
        /// Gets or sets primary key. Foreign key to BusinessEntity.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets primary key. Foreign key to Address.AddressID.
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Gets or sets primary key. Foreign key to AddressType.AddressTypeID.
        /// </summary>
        public int AddressTypeId { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Address Address { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual AddressType AddressType { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual BusinessEntity BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
