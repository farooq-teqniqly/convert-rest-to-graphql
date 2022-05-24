// <copyright file="ISalesPeopleRepository.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace Services.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Services.Models;

    public interface ISalesPeopleRepository
    {
        Task<IEnumerable<SalesPersonModel>> GetSalesPeopleAsync();

        Task<SalesPersonDetailModel> GetSalesPersonDetailsAsync(int businessEntityId);

        Task<int> AddSalesPersonAsync(AddSalesPersonModel addSalesPersonModel);
    }
}
