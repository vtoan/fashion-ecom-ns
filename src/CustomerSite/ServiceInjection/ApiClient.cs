using CustomerSite.Interfaces;
using CustomerSite.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerSite.ServiceInjection
{
    public static class ApiClient
    {
        public static IServiceCollection AddApiClient(this IServiceCollection services)
        {

            services.AddScoped<IRequestAPI, RequestAPI>();
            services.AddScoped<ICategoryApiClient, CategoryApiClient>();
            services.AddScoped<IOrderApiClient, OrderApiClient>();
            services.AddScoped<IProductApiClient, ProductApiClient>();
            services.AddScoped<IRatingApiClient, RatingApiClient>();
            return services;
        }
    }
}