using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using stockrain.application.Services.Repository;
using stockrain.infrestructure.Services.Implementations;

namespace stockrain.infrestructure
{
    public static class InfrestructureServiceRegistration
    {

        public static IServiceCollection AddInInfrestructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IGetStocksRepository, GetStocksMockDataRepository>();

            return services;
        }

    }
}
