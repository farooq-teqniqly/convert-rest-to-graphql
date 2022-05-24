// <copyright file="SalesPersonDetailModel.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace Services.Models
{
    using System;

    /// <summary>
    /// A model for returning sales person details.
    /// </summary>
    public class SalesPersonDetailModel
    {
        /// <summary>
        /// Gets or sets the sales person's id.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets the sales person's hire date.
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// Gets or sets the sales person's territory name.
        /// </summary>
        public string TerritoryName { get; set; }
    }
}