using BUS.Interfaces.Services;
using BUS.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Core.ServiceExtension
{
    public static class BUSService
    {
        public static IServiceCollection AddBUS(this IServiceCollection services)
        {

            services.AddScoped<ICategoryService, CategoryService>();
            // services.AddScoped<ITypeProductService, TypeProductService>();
            services.AddScoped<IFeeService, FeeService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductDetailService, ProductDetailService>();
            services.AddScoped<IRatingService, RatingService>();

            return services;
        }
    }
}