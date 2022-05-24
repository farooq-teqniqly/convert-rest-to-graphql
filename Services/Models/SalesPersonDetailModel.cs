// <copyright file="SalesPersonDetailModel.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

using System;

namespace Services.Models;

public class SalesPersonDetailModel
{
    public int BusinessEntityId { get; set; }

    public DateTime HireDate { get; set; }

    public string TerritoryName { get; set; }
}