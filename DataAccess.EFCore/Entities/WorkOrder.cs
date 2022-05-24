// <copyright file="WorkOrder.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Manufacturing work orders.
    /// </summary>
    public sealed class WorkOrder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrder"/> class.
        /// </summary>
        public WorkOrder()
        {
            this.WorkOrderRoutings = new HashSet<WorkOrderRouting>();
        }

        /// <summary>
        /// Gets or sets primary key for WorkOrder records.
        /// </summary>
        public int WorkOrderId { get; set; }

        /// <summary>
        /// Gets or sets product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets product quantity to build.
        /// </summary>
        public int OrderQty { get; set; }

        /// <summary>
        /// Gets or sets quantity built and put in inventory.
        /// </summary>
        public int StockedQty { get; set; }

        /// <summary>
        /// Gets or sets quantity that failed inspection.
        /// </summary>
        public short ScrappedQty { get; set; }

        /// <summary>
        /// Gets or sets work order start date.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets work order end date.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets work order due date.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets reason for inspection failure.
        /// </summary>
        public short? ScrapReasonId { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Product Product { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ScrapReason ScrapReason { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
