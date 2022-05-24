// <copyright file="SalesOrderHeader.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// General sales order information.
    /// </summary>
    public class SalesOrderHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderHeader"/> class.
        /// </summary>
        public SalesOrderHeader()
        {
            this.SalesOrderDetails = new HashSet<SalesOrderDetail>();
            this.SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();
        }

        /// <summary>
        /// Gets or sets primary key.
        /// </summary>
        public int SalesOrderId { get; set; }

        /// <summary>
        /// Gets or sets incremental number to track changes to the sales order over time.
        /// </summary>
        public byte RevisionNumber { get; set; }

        /// <summary>
        /// Gets or sets dates the sales order was created.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets date the order is due to the customer.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets date the order was shipped to the customer.
        /// </summary>
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// Gets or sets order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled.
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// Gets or sets 0 = Order placed by sales person. 1 = Order placed online by customer.
        /// </summary>
        public bool? OnlineOrderFlag { get; set; }

        /// <summary>
        /// Gets or sets unique sales order identification number.
        /// </summary>
        public string SalesOrderNumber { get; set; } = null!;

        /// <summary>
        /// Gets or sets customer purchase order number reference.
        /// </summary>
        public string? PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or sets financial accounting number reference.
        /// </summary>
        public string? AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets customer identification number. Foreign key to Customer.BusinessEntityID.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.
        /// </summary>
        public int? SalesPersonId { get; set; }

        /// <summary>
        /// Gets or sets territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.
        /// </summary>
        public int? TerritoryId { get; set; }

        /// <summary>
        /// Gets or sets customer billing address. Foreign key to Address.AddressID.
        /// </summary>
        public int BillToAddressId { get; set; }

        /// <summary>
        /// Gets or sets customer shipping address. Foreign key to Address.AddressID.
        /// </summary>
        public int ShipToAddressId { get; set; }

        /// <summary>
        /// Gets or sets shipping method. Foreign key to ShipMethod.ShipMethodID.
        /// </summary>
        public int ShipMethodId { get; set; }

        /// <summary>
        /// Gets or sets credit card identification number. Foreign key to CreditCard.CreditCardID.
        /// </summary>
        public int? CreditCardId { get; set; }

        /// <summary>
        /// Gets or sets approval code provided by the credit card company.
        /// </summary>
        public string? CreditCardApprovalCode { get; set; }

        /// <summary>
        /// Gets or sets currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.
        /// </summary>
        public int? CurrencyRateId { get; set; }

        /// <summary>
        /// Gets or sets sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.
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
        /// Gets or sets total due from customer. Computed as Subtotal + TaxAmt + Freight.
        /// </summary>
        public decimal TotalDue { get; set; }

        /// <summary>
        /// Gets or sets sales representative comments.
        /// </summary>
        public string? Comment { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Address BillToAddress { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual CreditCard? CreditCard { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual CurrencyRate? CurrencyRate { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Customer Customer { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual SalesPerson? SalesPerson { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ShipMethod ShipMethod { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Address ShipToAddress { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual SalesTerritory? Territory { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
