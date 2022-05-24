// <copyright file="SalesPersonModel.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace Services.Models
{
    /// <summary>
    /// A model representing a sales person.
    /// </summary>
    public class SalesPersonModel
    {
        /// <summary>
        /// Gets or sets the sales person's id.
        /// </summary>
        public int BusinessEntityId { get; set; }

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
    }
}
