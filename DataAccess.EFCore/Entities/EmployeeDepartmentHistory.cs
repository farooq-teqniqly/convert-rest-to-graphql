// <copyright file="EmployeeDepartmentHistory.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Employee department transfers.
    /// </summary>
    public class EmployeeDepartmentHistory
    {
        /// <summary>
        /// Gets or sets employee identification number. Foreign key to Employee.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets department in which the employee worked including currently. Foreign key to Department.DepartmentID.
        /// </summary>
        public short DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID.
        /// </summary>
        public byte ShiftId { get; set; }

        /// <summary>
        /// Gets or sets date the employee started work in the department.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date the employee left the department. NULL = Current department.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Employee BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Department Department { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Shift Shift { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
