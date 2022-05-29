// <copyright file="Program.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace GraphAPI
{
    using System.Threading.Tasks;
    using GraphQL;
    using GraphQL.MicrosoftDI;
    using GraphQL.SystemTextJson;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

    public class Program
    {
        public static void Main(string[] args)
        {
            var webApplicationBuilder = WebApplication.CreateBuilder(args);

            webApplicationBuilder.Services.AddGraphQL(builder =>
            {
                builder.ConfigureExecutionOptions(options =>
                {
                    options.EnableMetrics = webApplicationBuilder.Environment.IsDevelopment();

                    var logger = options.RequestServices!.GetRequiredService<ILogger<Program>>();

                    options.UnhandledExceptionDelegate = ctx =>
                    {
                        logger.LogError($"GraphQL startup error: {ctx.OriginalException.Message}");
                        return Task.CompletedTask;
                    };
                });

                builder.AddSystemTextJson();

                builder.AddErrorInfoProvider(
                    options => options.ExposeExceptionStackTrace = webApplicationBuilder.Environment.IsDevelopment());
            });

            var app = webApplicationBuilder.Build();
            app.UseHttpsRedirection();

            if (app.Environment.IsDevelopment())
            {
                app.UseGraphQLGraphiQL();
            }

            app.Run();
        }
    }
}