using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core.ServiceExtensions
{
    public static class ReadConfig
    {
        public static Dictionary<string, string> clientUrls;

        public static IServiceCollection AddReadConfig(this IServiceCollection services, IConfiguration configuration)
        {
            try
            {
                clientUrls = new Dictionary<string, string>()
                {
                    ["react"] = configuration["ClientUrls:react"],
                    ["mvc"] = configuration["ClientUrls:mvc"],
                };
            }
            catch (Exception)
            {
                throw new Exception("No define client url");
            }
            return services;
        }
    }
}