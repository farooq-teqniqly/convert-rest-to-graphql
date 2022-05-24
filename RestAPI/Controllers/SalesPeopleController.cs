// <copyright file="SalesPeopleController.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Controllers
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Services.Models;
    using Services.Repositories;

    /// <summary>
    /// The controller to work with Sales People entities.
    /// </summary>
    [ApiController]
    [Route("api/salespeople")]
    public class SalesPeopleController : ControllerBase
    {
        private readonly ISalesPeopleRepository salesPeopleRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesPeopleController"/> class.
        /// </summary>
        /// <param name="salesPeopleRepository">The sales person repository.</param>
        public SalesPeopleController(ISalesPeopleRepository salesPeopleRepository)
        {
            this.salesPeopleRepository = salesPeopleRepository;
        }

        /// <summary>
        /// Returns all sales people.
        /// </summary>
        /// <returns>The list of sales people.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<SalesPersonModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllSalesPeople()
        {
            var salesPeople = await this.salesPeopleRepository.GetSalesPeopleAsync();
            return this.Ok(salesPeople);
        }

        /// <summary>
        /// Gets the sales person's details with the specified id.
        /// </summary>
        /// <param name="id">The person's id.</param>
        /// <returns>The sales person's details.</returns>
        [HttpGet("{id}", Name = nameof(GetSalesPersonDetails))]
        [ProducesResponseType(typeof(SalesPersonDetailModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetSalesPersonDetails(int id)
        {
            var salesPerson = await this.salesPeopleRepository.GetSalesPersonDetailsAsync(id);
            return this.Ok(salesPerson);
        }

        /// <summary>
        /// Adds a new sales person.
        /// </summary>
        /// <param name="model">The model containing the sale person's information.</param>
        /// <returns>The sales person's id.</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<IActionResult> AddSalesPerson([FromBody] AddSalesPersonModel model)
        {
            var id = await this.salesPeopleRepository.AddSalesPersonAsync(model);
            return this.CreatedAtRoute(nameof(this.GetSalesPersonDetails), new { id }, null);
        }
    }
}
