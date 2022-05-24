// <copyright file="Store.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Customers (resellers) of Adventure Works products.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Store"/> class.
        /// </summary>
        public Store()
        {
            this.Customers = new HashSet<Customer>();
        }

        /// <summary>
        /// Gets or sets primary key. Foreign key to Customer.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets name of the store.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets iD of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.
        /// </summary>
        public int? SalesPersonId { get; set; }

        /// <summary>
        /// Gets or sets demographic informationg about the store such as the number of employees, annual sales and store type.
        /// </summary>
        public string Demographics { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual BusinessEntity BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual SalesPerson SalesPerson { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<Customer> Customers { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
