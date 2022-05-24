// <copyright file="PurchaseOrderHeader.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// General purchase order information. See PurchaseOrderDetail.
    /// </summary>
    public class PurchaseOrderHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderHeader"/> class.
        /// </summary>
        public PurchaseOrderHeader()
        {
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
        }

        /// <summary>
        /// Gets or sets primary key.
        /// </summary>
        public int PurchaseOrderId { get; set; }

        /// <summary>
        /// Gets or sets incremental number to track changes to the purchase order over time.
        /// </summary>
        public byte RevisionNumber { get; set; }

        /// <summary>
        /// Gets or sets order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete.
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// Gets or sets employee who created the purchase order. Foreign key to Employee.BusinessEntityID.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.
        /// </summary>
        public int VendorId { get; set; }

        /// <summary>
        /// Gets or sets shipping method. Foreign key to ShipMethod.ShipMethodID.
        /// </summary>
        public int ShipMethodId { get; set; }

        /// <summary>
        /// Gets or sets purchase order creation date.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets estimated shipment date from the vendor.
        /// </summary>
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// Gets or sets purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.
        /// </summary>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Gets or sets tax amount.
        /// </summary>
        public decimal TaxAmt { get; set; }

        /// <summary>
        /// Gets or sets shipping cost.
        /// </summary>
        public decimal Freight { get; set; }

        /// <summary>
        /// Gets or sets total due to vendor. Computed as Subtotal + TaxAmt + Freight.
        /// </summary>
        public decimal TotalDue { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Employee Employee { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ShipMethod ShipMethod { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Vendor Vendor { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
