// <copyright file="ShipMethod.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Shipping company lookup table.
    /// </summary>
    public class ShipMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipMethod"/> class.
        /// </summary>
        public ShipMethod()
        {
            this.PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        /// Gets or sets primary key for ShipMethod records.
        /// </summary>
        public int ShipMethodId { get; set; }

        /// <summary>
        /// Gets or sets shipping company name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets minimum shipping charge.
        /// </summary>
        public decimal ShipBase { get; set; }

        /// <summary>
        /// Gets or sets shipping charge per pound.
        /// </summary>
        public decimal ShipRate { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
