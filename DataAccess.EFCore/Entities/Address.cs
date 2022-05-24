// <copyright file="Address.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Street address information for customers, employees, and vendors.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
            this.BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
            this.SalesOrderHeaderBillToAddresses = new HashSet<SalesOrderHeader>();
            this.SalesOrderHeaderShipToAddresses = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        /// Gets or sets primary key for Address records.
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Gets or sets first street address line.
        /// </summary>
        public string AddressLine1 { get; set; } = null!;

        /// <summary>
        /// Gets or sets second street address line.
        /// </summary>
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets name of the city.
        /// </summary>
        public string City { get; set; } = null!;

        /// <summary>
        /// Gets or sets unique identification number for the state or province. Foreign key to StateProvince table.
        /// </summary>
        public int StateProvinceId { get; set; }

        /// <summary>
        /// Gets or sets postal code for the street address.
        /// </summary>
        public string PostalCode { get; set; } = null!;

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual StateProvince StateProvince { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaderBillToAddresses { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaderShipToAddresses { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
