// <copyright file="ISalesPeopleRepository.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace Services.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Services.Models;

    /// <summary>
    /// Defines an interface that reads/writes sales people entities to/from a data store.
    /// </summary>
    public interface ISalesPeopleRepository
    {
        /// <summary>
        /// Gets all sales people.
        /// </summary>
        /// <returns>The list of all sales people.</returns>
        Task<IEnumerable<SalesPersonModel>> GetSalesPeopleAsync();

        /// <summary>
        /// Gets a sales person's details.
        /// </summary>
        /// <param name="businessEntityId">The sales person's id.</param>
        /// <returns>The sales person's details.</returns>
        Task<SalesPersonDetailModel> GetSalesPersonDetailsAsync(int businessEntityId);

        /// <summary>
        /// Adds a sales person to the data store.
        /// </summary>
        /// <param name="addSalesPersonModel">The sales person's information.</param>
        /// <returns>The created sales person's id.</returns>
        Task<int> AddSalesPersonAsync(AddSalesPersonModel addSalesPersonModel);
    }
}
