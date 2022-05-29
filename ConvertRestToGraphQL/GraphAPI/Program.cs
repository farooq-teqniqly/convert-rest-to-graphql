// <copyright file="Program.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

using System.Linq;
using System.Threading.Tasks;
using DataAccess.EFCore;
using DataAccess.Graph.Queries;
using DataAccess.Graph.Schemas;
using DataAccess.Graph.Types;
using GraphiQl;
using GraphQL.Types;
using GraphQL.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GraphAPI
{
    using GraphQL.SystemTextJson;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<TelemetryDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("TelemetryDb")));

            builder.Services.AddScoped<TelemetryType>();
            builder.Services.AddScoped<DeviceType>();
            builder.Services.AddScoped<RootQuery>();
            builder.Services.AddScoped<TelemetryQuery>();
            builder.Services.AddScoped<ISchema, RootSchema>();

            builder.Services.AddGraphQL(options =>
            {
                options.EnableMetrics = builder.Environment.IsDevelopment();
            }).AddSystemTextJson();

            var app = builder.Build();
            app.UseHttpsRedirection();

            if (app.Environment.IsDevelopment())
            {
                app.UseGraphiQl("/graphiql");
            }

            app.UseGraphQL<ISchema>();
            app.Run();
        }
    }
}