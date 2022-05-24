// <copyright file="AddSalesPersonModel.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace Services.Models
{
    using System;

    /// <summary>
    /// The model used when adding a new sales person.
    /// </summary>
    public class AddSalesPersonModel
    {
        /// <summary>
        /// Gets or sets the sales person's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the sales person's middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the sales person's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the sales person's hire date.
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// Gets or sets the sales person's territory id.
        /// </summary>
        public int TerritoryId { get; set; }

        /// <summary>
        /// Gets or sets the sales person's gender.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the sales person's job title.
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets the sales person's marital status.
        /// </summary>
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Gets or sets the sales person's login id.
        /// </summary>
        public string LoginId { get; set; }

        /// <summary>
        /// Gets or sets the sales person's national id number.
        /// </summary>
        public string NationalIdNumber { get; set; }

        /// <summary>
        /// Gets or sets the sales person's birth date.
        /// </summary>
        public DateTime BirthDate { get; set; }
    }
}
