// <copyright file="ISalesPeopleRepository.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace Services.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using DataAccess.EFCore;
    using DataAccess.EFCore.Entities;
    using Microsoft.EntityFrameworkCore;
    using Services.Models;

    public interface ISalesPeopleRepository
    {
        Task<IEnumerable<SalesPersonModel>> GetSalesPeopleAsync();

        Task<SalesPersonDetailModel> GetSalesPersonDetailsAsync(int businessEntityId);
    }

    public class SalesPeopleRepository : ISalesPeopleRepository
    {
        private readonly AdventureWorks2019Context dbContext;
        private readonly IMapper mapper;

        public SalesPeopleRepository(AdventureWorks2019Context dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<SalesPersonModel>> GetSalesPeopleAsync()
        {
            var salesPeople = await this.dbContext.SalesPeople
                .Include(sp => sp.BusinessEntity)
                .ThenInclude(e => e.BusinessEntity)
                .ToListAsync();

            return this.mapper.Map<IEnumerable<SalesPerson>, IEnumerable<SalesPersonModel>>(salesPeople);
        }

        public async Task<SalesPersonDetailModel> GetSalesPersonDetailsAsync(int businessEntityId)
        {
            var salesPerson = await this.dbContext.SalesPeople
                .Include(sp => sp.Territory)
                .Include(sp => sp.BusinessEntity)
                .SingleOrDefaultAsync(sp => sp.BusinessEntityId == businessEntityId);

            return this.mapper.Map<SalesPerson, SalesPersonDetailModel>(salesPerson);
        }
    }
}
