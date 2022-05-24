// <copyright file="EmployeePayHistory.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Employee pay history.
    /// </summary>
    public class EmployeePayHistory
    {
        /// <summary>
        /// Gets or sets employee identification number. Foreign key to Employee.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets date the change in pay is effective.
        /// </summary>
        public DateTime RateChangeDate { get; set; }

        /// <summary>
        /// Gets or sets salary hourly rate.
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// Gets or sets 1 = Salary received monthly, 2 = Salary received biweekly.
        /// </summary>
        public byte PayFrequency { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Employee BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
