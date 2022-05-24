// <copyright file="Employee.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Employee information such as salary, department, and title.
    /// </summary>
    public sealed class Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
            this.EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
            this.EmployeePayHistories = new HashSet<EmployeePayHistory>();
            this.JobCandidates = new HashSet<JobCandidate>();
            this.PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
        }

        /// <summary>
        /// Gets or sets primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets unique national identification number such as a social security number.
        /// </summary>
        public string NationalIdnumber { get; set; } = null!;

        /// <summary>
        /// Gets or sets network login.
        /// </summary>
        public string LoginId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the depth of the employee in the corporate hierarchy.
        /// </summary>
        public short? OrganizationLevel { get; set; }

        /// <summary>
        /// Gets or sets work title such as Buyer or Sales Representative.
        /// </summary>
        public string JobTitle { get; set; } = null!;

        /// <summary>
        /// Gets or sets date of birth.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets m = Married, S = Single.
        /// </summary>
        public string MaritalStatus { get; set; } = null!;

        /// <summary>
        /// Gets or sets m = Male, F = Female.
        /// </summary>
        public string Gender { get; set; } = null!;

        /// <summary>
        /// Gets or sets employee hired on this date.
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// Gets or sets job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.
        /// </summary>
        public bool? SalariedFlag { get; set; }

        /// <summary>
        /// Gets or sets number of available vacation hours.
        /// </summary>
        public short VacationHours { get; set; }

        /// <summary>
        /// Gets or sets number of available sick leave hours.
        /// </summary>
        public short SickLeaveHours { get; set; }

        /// <summary>
        /// Gets or sets 0 = Inactive, 1 = Active.
        /// </summary>
        public bool? CurrentFlag { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Person BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public SalesPerson SalesPerson { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<JobCandidate> JobCandidates { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
