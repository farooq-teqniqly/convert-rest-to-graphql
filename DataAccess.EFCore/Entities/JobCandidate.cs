// <copyright file="JobCandidate.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Résumés submitted to Human Resources by job applicants.
    /// </summary>
    public class JobCandidate
    {
        /// <summary>
        /// Gets or sets primary key for JobCandidate records.
        /// </summary>
        public int JobCandidateId { get; set; }

        /// <summary>
        /// Gets or sets employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.
        /// </summary>
        public int? BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets résumé in XML format.
        /// </summary>
        public string? Resume { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Employee? BusinessEntity { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
