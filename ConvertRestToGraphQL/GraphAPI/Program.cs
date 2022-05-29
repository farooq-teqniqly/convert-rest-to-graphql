// <copyright file="Program.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace GraphAPI
{
    using System.Threading.Tasks;
    using DataAccess.EFCore;
    using DataAccess.Graph.Queries;
    using DataAccess.Graph.Schemas;
    using DataAccess.Graph.Types;
    using GraphQL;
    using GraphQL.MicrosoftDI;
    using GraphQL.Server;
    using GraphQL.Server.Transports.AspNetCore;
    using GraphQL.Server.Ui.Playground;
    using GraphQL.SystemTextJson;
    using GraphQL.Types;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// The GraphQL API.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The API entry point.
        /// </summary>
        /// <param name="args">Arguments to the program.</param>
        public static void Main(string[] args)
        {
            var webApplicationBuilder = WebApplication.CreateBuilder(args);

            webApplicationBuilder.Services.AddDbContext<TelemetryDbContext>(
                options =>
                options.UseSqlServer(webApplicationBuilder.Configuration.GetConnectionString("TelemetryDb")),
                ServiceLifetime.Transient,
                ServiceLifetime.Transient);

            webApplicationBuilder.Services.AddTransient<TelemetryType>();
            webApplicationBuilder.Services.AddTransient<DeviceType>();
            webApplicationBuilder.Services.AddTransient<RootQuery>();
            webApplicationBuilder.Services.AddTransient<TelemetryQuery>();
            webApplicationBuilder.Services.AddTransient<ISchema, RootSchema>();

            webApplicationBuilder.Services.AddGraphQL(builder =>
            {
                builder.AddApolloTracing(webApplicationBuilder.Environment.IsDevelopment());
                builder.AddHttpMiddleware<RootSchema, GraphQLHttpMiddleware<RootSchema>>();
                builder.AddSchema<RootSchema>();
                builder.ConfigureExecutionOptions(options =>
                {
                    options.EnableMetrics = webApplicationBuilder.Environment.IsDevelopment();
                    var logger = options.RequestServices.GetRequiredService<ILogger<Program>>();
                    options.UnhandledExceptionDelegate = ctx =>
                    {
                        logger.LogError($"GraphQL startup error: {ctx.OriginalException.Message}");
                        return Task.CompletedTask;
                    };
                });

                builder.AddSystemTextJson();
                builder.AddGraphTypes(typeof(RootSchema).Assembly);
            });

            var app = webApplicationBuilder.Build();
            app.UseHttpsRedirection();

            if (app.Environment.IsDevelopment())
            {
                app.UseGraphQLPlayground(new PlaygroundOptions());
            }

            app.UseGraphQL<RootSchema>();
            app.Run();
        }
    }
}