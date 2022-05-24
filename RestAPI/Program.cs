// <copyright file="Program.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI
{
    using DataAccess.EFCore;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Services.Repositories;

    /// <summary>
    /// The API entry point class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The API entry point.
        /// </summary>
        /// <param name="args">Arguments to the program.</param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<AdventureWorks2019Context>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("AdventureWorksDb")));

            builder.Services.AddScoped<ISalesPeopleRepository, SalesPeopleRepository>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}