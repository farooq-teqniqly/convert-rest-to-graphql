// <copyright file="MappingProfile.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace Services.Mappers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using AutoMapper;
    using DataAccess.EFCore.Entities;
    using Services.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<SalesPerson, SalesPersonModel>().ConvertUsing<SalesPersonModelMapper>();
            this.CreateMap<SalesPerson, SalesPersonDetailModel>().ConvertUsing<SalesPersonDetailModelMapper>();
        }
    }
}
