// <copyright file="AwbuildVersion.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Current version number of the AdventureWorks 2016 sample database.
    /// </summary>
    public class AwbuildVersion
    {
        /// <summary>
        /// Gets or sets primary key for AWBuildVersion records.
        /// </summary>
        public byte SystemInformationId { get; set; }

        /// <summary>
        /// Gets or sets version number of the database in 9.yy.mm.dd.00 format.
        /// </summary>
        public string DatabaseVersion { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime VersionDate { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}
