using BUS.Interfaces.Services;
using BUS.Services;
using Core.Interfaces;
using Core.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Core.ServiceExtensions
{
    public static class HelpfulServices
    {
        public static IServiceCollection AddHelpful(this IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();

            return services;
        }
    }
}