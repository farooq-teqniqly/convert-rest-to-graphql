// <copyright file="SalesPersonDetailModelMapper.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

using AutoMapper;
using DataAccess.EFCore.Entities;
using Services.Models;

namespace Services.Mappers;

public class SalesPersonDetailModelMapper : ITypeConverter<SalesPerson, SalesPersonDetailModel>
{
    public SalesPersonDetailModel Convert(SalesPerson source, SalesPersonDetailModel destination, ResolutionContext context)
    {
        return new SalesPersonDetailModel
        {
            BusinessEntityId = source.BusinessEntityId,
            HireDate = source.BusinessEntity.HireDate,
            TerritoryName = source.Territory?.Name,
        };
    }
}