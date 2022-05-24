// <copyright file="Customer.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Current customer information. Also see the Person and Store tables.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        /// Gets or sets primary key.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets foreign key to Person.BusinessEntityID.
        /// </summary>
        public int? PersonId { get; set; }

        /// <summary>
        /// Gets or sets foreign key to Store.BusinessEntityID.
        /// </summary>
        public int? StoreId { get; set; }

        /// <summary>
        /// Gets or sets iD of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.
        /// </summary>
        public int? TerritoryId { get; set; }

        /// <summary>
        /// Gets or sets unique number identifying the customer assigned by the accounting system.
        /// </summary>
        public string AccountNumber { get; set; } = null!;

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Person Person { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Store Store { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual SalesTerritory Territory { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
