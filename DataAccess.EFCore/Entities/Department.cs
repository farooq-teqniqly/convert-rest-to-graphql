// <copyright file="Department.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Lookup table containing the departments within the Adventure Works Cycles company.
    /// </summary>
    public sealed class Department
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Department"/> class.
        /// </summary>
        public Department()
        {
            this.EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
        }

        /// <summary>
        /// Gets or sets primary key for Department records.
        /// </summary>
        public short DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets name of the department.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets name of the group to which the department belongs.
        /// </summary>
        public string GroupName { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
