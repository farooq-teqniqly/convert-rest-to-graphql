// <copyright file="Program.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace RestAPI
{
    using AutoMapper;
    using DataAccess.EFCore;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Services.Mappers;
    using Services.Repositories;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<AdventureWorks2019Context>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("AdventureWorksDb")));

            var mapperConfig = new MapperConfiguration(
                cfg => cfg.AddProfile<MappingProfile>());

            var mapper = new Mapper(mapperConfig);
            builder.Services.AddScoped<IMapper>(_ => mapper);

            builder.Services.AddScoped<ISalesPeopleRepository, SalesPeopleRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
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