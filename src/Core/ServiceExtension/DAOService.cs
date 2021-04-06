using BUS.Domains;
using BUS.Interfaces.DAOs;
using DAO.DAOs;
using Microsoft.Extensions.DependencyInjection;

namespace Core.ServiceExtension
{
    public static class DAOService
    {
        public static IServiceCollection AddDAO(this IServiceCollection services)
        {
            services.AddScoped<IBaseDAO<Category>, BaseDAO<Category>>();
            // services.AddScoped<IBaseDAO<TypeProduct>, BaseDAO<TypeProduct>>();
            services.AddScoped<IBaseDAO<Fee>, BaseDAO<Fee>>();
            services.AddScoped<IProductDAO, ProductDAO>();
            services.AddScoped<IOrderDAO, OrderDAO>();
            services.AddScoped<IProductDetailDAO, ProductDetailDAO>();
            services.AddScoped<IRatingDAO, RatingDAO>();
            return services;
        }
    }
}