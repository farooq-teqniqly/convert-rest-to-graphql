// <copyright file="WorkOrderRouting.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Work order details.
    /// </summary>
    public class WorkOrderRouting
    {
        /// <summary>
        /// Gets or sets primary key. Foreign key to WorkOrder.WorkOrderID.
        /// </summary>
        public int WorkOrderId { get; set; }

        /// <summary>
        /// Gets or sets primary key. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets primary key. Indicates the manufacturing process sequence.
        /// </summary>
        public short OperationSequence { get; set; }

        /// <summary>
        /// Gets or sets manufacturing location where the part is processed. Foreign key to Location.LocationID.
        /// </summary>
        public short LocationId { get; set; }

        /// <summary>
        /// Gets or sets planned manufacturing start date.
        /// </summary>
        public DateTime ScheduledStartDate { get; set; }

        /// <summary>
        /// Gets or sets planned manufacturing end date.
        /// </summary>
        public DateTime ScheduledEndDate { get; set; }

        /// <summary>
        /// Gets or sets actual start date.
        /// </summary>
        public DateTime? ActualStartDate { get; set; }

        /// <summary>
        /// Gets or sets actual end date.
        /// </summary>
        public DateTime? ActualEndDate { get; set; }

        /// <summary>
        /// Gets or sets number of manufacturing hours used.
        /// </summary>
        public decimal? ActualResourceHrs { get; set; }

        /// <summary>
        /// Gets or sets estimated manufacturing cost.
        /// </summary>
        public decimal PlannedCost { get; set; }

        /// <summary>
        /// Gets or sets actual manufacturing cost.
        /// </summary>
        public decimal? ActualCost { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Location Location { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual WorkOrder WorkOrder { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
