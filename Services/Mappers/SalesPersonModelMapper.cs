// <copyright file="SalesPersonModelMapper.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace Services.Mappers
{
    using AutoMapper;
    using DataAccess.EFCore.Entities;
    using Services.Models;

    public class SalesPersonModelMapper : ITypeConverter<SalesPerson, SalesPersonModel>
    {
        public SalesPersonModel Convert(SalesPerson source, SalesPersonModel destination, ResolutionContext context)
        {
            return new SalesPersonModel
            {
                BusinessEntityId = source.BusinessEntityId,
                FirstName = source.BusinessEntity.BusinessEntity.FirstName,
                MiddleName = source.BusinessEntity.BusinessEntity.MiddleName,
                LastName = source.BusinessEntity.BusinessEntity.LastName,
            };
        }
    }
}
