// <copyright file="Culture.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Lookup table containing the languages in which some AdventureWorks data is stored.
    /// </summary>
    public class Culture
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Culture"/> class.
        /// </summary>
        public Culture()
        {
            this.ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        }

        /// <summary>
        /// Gets or sets primary key for Culture records.
        /// </summary>
        public string CultureId { get; set; } = null!;

        /// <summary>
        /// Gets or sets culture description.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
