using BUS.Domains;
using BUS.Interfaces.DAOs;
using DAO.DAOs;
using Microsoft.Extensions.DependencyInjection;

namespace Core.ServiceInjection
{
    public static class DAOServices
    {
        public static IServiceCollection AddDAO(this IServiceCollection services)
        {
            services.AddScoped<ICategoryDAO, CategoryDAO>();
            services.AddScoped<IBaseDAO<TypeProduct>, BaseDAO<TypeProduct>>();
            services.AddScoped<IBaseDAO<Fee>, BaseDAO<Fee>>();
            services.AddScoped<IProductDAO, ProductDAO>();
            services.AddScoped<IOrderDAO, OrderDAO>();
            services.AddScoped<IProductAttrDAO, ProductAttrDAO>();
            services.AddScoped<IRatingDAO, RatingDAO>();
            services.AddScoped<IUserDAO, UserDAO>();
            return services;
        }
    }
}