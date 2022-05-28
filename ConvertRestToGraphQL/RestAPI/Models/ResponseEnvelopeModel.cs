// <copyright file="ResponseEnvelopeModel.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// A container for API response data.
    /// </summary>
    /// <typeparam name="T">The type contained in the response.</typeparam>
    public class ResponseEnvelopeModel<T>
        where T : class
    {
        /// <summary>
        /// Gets or sets the number of items in the response data.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the response data.
        /// </summary>
        public List<T> Data { get; set; }
    }
}
