// <copyright file="SalesPerson.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Sales representative current information.
    /// </summary>
    public class SalesPerson
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesPerson"/> class.
        /// </summary>
        public SalesPerson()
        {
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            this.SalesPersonQuotaHistories = new HashSet<SalesPersonQuotaHistory>();
            this.SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
            this.Stores = new HashSet<Store>();
        }

        /// <summary>
        /// Gets or sets primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.
        /// </summary>
        public int? TerritoryId { get; set; }

        /// <summary>
        /// Gets or sets projected yearly sales.
        /// </summary>
        public decimal? SalesQuota { get; set; }

        /// <summary>
        /// Gets or sets bonus due if quota is met.
        /// </summary>
        public decimal Bonus { get; set; }

        /// <summary>
        /// Gets or sets commision percent received per sale.
        /// </summary>
        public decimal CommissionPct { get; set; }

        /// <summary>
        /// Gets or sets sales total year to date.
        /// </summary>
        public decimal SalesYtd { get; set; }

        /// <summary>
        /// Gets or sets sales total of previous year.
        /// </summary>
        public decimal SalesLastYear { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Employee BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual SalesTerritory Territory { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<Store> Stores { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
