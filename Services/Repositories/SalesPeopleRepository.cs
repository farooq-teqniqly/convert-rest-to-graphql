// <copyright file="SalesPeopleRepository.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace Services.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using DataAccess.EFCore;
    using DataAccess.EFCore.Entities;
    using Microsoft.EntityFrameworkCore;
    using Services.Models;

    /// <summary>
    /// Reads/writes sales people to/from the database.
    /// </summary>
    public class SalesPeopleRepository : ISalesPeopleRepository
    {
        private readonly AdventureWorks2019Context dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesPeopleRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The EF Core database context.</param>
        public SalesPeopleRepository(AdventureWorks2019Context dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<SalesPersonModel>> GetSalesPeopleAsync()
        {
            return await this.dbContext.SalesPeople
                .AsNoTracking()
                .Include(sp => sp.BusinessEntity)
                .ThenInclude(e => e.BusinessEntity)
                .Select(sp => new SalesPersonModel
                {
                    BusinessEntityId = sp.BusinessEntityId,
                    FirstName = sp.BusinessEntity.BusinessEntity.FirstName,
                    LastName = sp.BusinessEntity.BusinessEntity.LastName,
                    MiddleName = sp.BusinessEntity.BusinessEntity.MiddleName,
                })
                .ToListAsync();
        }

        /// <inheritdoc/>
        public async Task<SalesPersonDetailModel> GetSalesPersonDetailsAsync(int businessEntityId)
        {
            return await this.dbContext.SalesPeople
                .AsNoTracking()
                .Include(sp => sp.Territory)
                .Include(sp => sp.BusinessEntity)
                .Select(sp => new SalesPersonDetailModel
                {
                    BusinessEntityId = sp.BusinessEntityId,
                    HireDate = sp.BusinessEntity.HireDate,
                    TerritoryName = sp.Territory.Name,
                })
                .SingleOrDefaultAsync(sp => sp.BusinessEntityId == businessEntityId);
        }

        /// <inheritdoc/>
        public async Task<int> AddSalesPersonAsync(AddSalesPersonModel addSalesPersonModel)
        {
            var businessEntity = new BusinessEntity();
            await this.dbContext.BusinessEntities.AddAsync(businessEntity);
            await this.dbContext.SaveChangesAsync();

            var person = new Person
            {
                BusinessEntityId = businessEntity.BusinessEntityId,
                FirstName = addSalesPersonModel.FirstName,
                MiddleName = addSalesPersonModel.MiddleName,
                LastName = addSalesPersonModel.LastName,
                PersonType = "SP",
            };

            var employee = new Employee
            {
                BusinessEntityId = businessEntity.BusinessEntityId,
                HireDate = addSalesPersonModel.HireDate,
                Gender = addSalesPersonModel.Gender,
                JobTitle = addSalesPersonModel.JobTitle,
                MaritalStatus = addSalesPersonModel.MaritalStatus,
                LoginId = $"adventure-works\\{addSalesPersonModel.LoginId}",
                NationalIdnumber = addSalesPersonModel.NationalIdNumber,
                BirthDate = addSalesPersonModel.BirthDate,
            };

            var salesPerson = new SalesPerson
            {
                BusinessEntityId = businessEntity.BusinessEntityId,
                TerritoryId = addSalesPersonModel.TerritoryId,
            };

            await this.dbContext.People.AddAsync(person);
            await this.dbContext.Employees.AddAsync(employee);
            await this.dbContext.SalesPeople.AddAsync(salesPerson);

            await this.dbContext.SaveChangesAsync();

            return businessEntity.BusinessEntityId;
        }
    }
}