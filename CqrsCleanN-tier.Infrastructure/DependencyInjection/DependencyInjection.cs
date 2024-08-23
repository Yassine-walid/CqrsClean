using CqrsCleanN_tier.Domain.Interfaces;
using CqrsCleanN_tier.Infrastructure.Data;
using CqrsCleanN_tier.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsCleanN_tier.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {
            services.AddSingleton<DbConnection>();
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
