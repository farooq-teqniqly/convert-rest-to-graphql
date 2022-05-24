// <copyright file="VSalesPersonSalesByFiscalYear.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    /// <summary>
    /// Uses PIVOT to return aggregated sales information for each sales representative.
    /// </summary>
    public class VSalesPersonSalesByFiscalYear
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int? SalesPersonId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string FullName { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string JobTitle { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string SalesTerritory { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1300 // Element should begin with upper-case letter
        public decimal? _2002 { get; set; }
#pragma warning restore SA1300 // Element should begin with upper-case letter
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1300 // Element should begin with upper-case letter
        public decimal? _2003 { get; set; }
#pragma warning restore SA1300 // Element should begin with upper-case letter
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1300 // Element should begin with upper-case letter
        public decimal? _2004 { get; set; }
#pragma warning restore SA1300 // Element should begin with upper-case letter
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
