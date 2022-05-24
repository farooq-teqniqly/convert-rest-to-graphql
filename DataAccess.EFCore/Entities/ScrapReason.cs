// <copyright file="ScrapReason.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Manufacturing failure reasons lookup table.
    /// </summary>
    public class ScrapReason
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapReason"/> class.
        /// </summary>
        public ScrapReason()
        {
            this.WorkOrders = new HashSet<WorkOrder>();
        }

        /// <summary>
        /// Gets or sets primary key for ScrapReason records.
        /// </summary>
        public short ScrapReasonId { get; set; }

        /// <summary>
        /// Gets or sets failure description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
