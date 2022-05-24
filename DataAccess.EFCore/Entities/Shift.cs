// <copyright file="Shift.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Work shift lookup table.
    /// </summary>
    public class Shift
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shift"/> class.
        /// </summary>
        public Shift()
        {
            this.EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
        }

        /// <summary>
        /// Gets or sets primary key for Shift records.
        /// </summary>
        public byte ShiftId { get; set; }

        /// <summary>
        /// Gets or sets shift description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets shift start time.
        /// </summary>
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Gets or sets shift end time.
        /// </summary>
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
