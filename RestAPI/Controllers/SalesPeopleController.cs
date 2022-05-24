// <copyright file="SalesPeopleController.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI.Controllers
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Services.Models;
    using Services.Repositories;

    [ApiController]
    [Route("api/salespeople")]
    public class SalesPeopleController : ControllerBase
    {
        private readonly ILogger<SalesPeopleController> logger;
        private readonly ISalesPeopleRepository salesPeopleRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesPeopleController"/> class.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="salesPeopleRepository"></param>
        public SalesPeopleController(ILogger<SalesPeopleController> logger, ISalesPeopleRepository salesPeopleRepository)
        {
            this.logger = logger;
            this.salesPeopleRepository = salesPeopleRepository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<SalesPersonModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllSalesPeople()
        {
            var salesPeople = await this.salesPeopleRepository.GetSalesPeopleAsync();
            return this.Ok(salesPeople);
        }

        [HttpGet("{id}", Name = nameof(GetSalesPersonDetails))]
        [ProducesResponseType(typeof(SalesPersonDetailModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetSalesPersonDetails(int id)
        {
            var salesPerson = await this.salesPeopleRepository.GetSalesPersonDetailsAsync(id);
            return this.Ok(salesPerson);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<IActionResult> AddSalesPerson([FromBody] AddSalesPersonModel model)
        {
            var id = await this.salesPeopleRepository.AddSalesPersonAsync(model);
            return this.CreatedAtRoute(nameof(GetSalesPersonDetails), new {id}, null);
        }
    }
}
