// <copyright file="Illustration.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Bicycle assembly diagrams.
    /// </summary>
    public class Illustration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Illustration"/> class.
        /// </summary>
        public Illustration()
        {
            this.ProductModelIllustrations = new HashSet<ProductModelIllustration>();
        }

        /// <summary>
        /// Gets or sets primary key for Illustration records.
        /// </summary>
        public int IllustrationId { get; set; }

        /// <summary>
        /// Gets or sets illustrations used in manufacturing instructions. Stored as XML.
        /// </summary>
        public string? Diagram { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
