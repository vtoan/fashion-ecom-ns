using BUS.Interfaces.Services;
using BUS.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Core.ServiceExtensions
{
    public static class BUSServices
    {
        public static IServiceCollection AddBUS(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ITypeProductService, TypeProductService>();
            services.AddScoped<IFeeService, FeeService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductAttrService, ProductAttrService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}