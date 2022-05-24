// <copyright file="ErrorLog.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;

    /// <summary>
    /// Audit table tracking errors in the the AdventureWorks database that are caught by the CATCH block of a TRY...CATCH construct. Data is inserted by stored procedure dbo.uspLogError when it is executed from inside the CATCH block of a TRY...CATCH construct.
    /// </summary>
    public class ErrorLog
    {
        /// <summary>
        /// Gets or sets primary key for ErrorLog records.
        /// </summary>
        public int ErrorLogId { get; set; }

        /// <summary>
        /// Gets or sets the date and time at which the error occurred.
        /// </summary>
        public DateTime ErrorTime { get; set; }

        /// <summary>
        /// Gets or sets the user who executed the batch in which the error occurred.
        /// </summary>
        public string UserName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the error number of the error that occurred.
        /// </summary>
        public int ErrorNumber { get; set; }

        /// <summary>
        /// Gets or sets the severity of the error that occurred.
        /// </summary>
        public int? ErrorSeverity { get; set; }

        /// <summary>
        /// Gets or sets the state number of the error that occurred.
        /// </summary>
        public int? ErrorState { get; set; }

        /// <summary>
        /// Gets or sets the name of the stored procedure or trigger where the error occurred.
        /// </summary>
        public string ErrorProcedure { get; set; }

        /// <summary>
        /// Gets or sets the line number at which the error occurred.
        /// </summary>
        public int? ErrorLine { get; set; }

        /// <summary>
        /// Gets or sets the message text of the error that occurred.
        /// </summary>
        public string ErrorMessage { get; set; } = null!;
    }
}
