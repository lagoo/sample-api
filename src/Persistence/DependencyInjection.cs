﻿using Application.Common.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Support.Configuration;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();

            services.Configure<DbConnectionConfig>(options => configuration.GetSection("DbConnection").Bind(options));

            services.AddDbContext<ApplicationContextSqlServer>();

            services.AddScoped<IApplicationContext>(provider => provider.GetService<ApplicationContextSqlServer>());

            return services;
        }
    }
}
