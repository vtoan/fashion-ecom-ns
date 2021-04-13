using System;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerSite.ServiceInjection
{
    public static class ConfigHttpClient
    {
        public static IServiceCollection AddConfigHttpClient(this IServiceCollection services, IConfiguration configuration)
        {

            // url
            Startup.HostUri = configuration.GetValue<string>("HostUri");

            services.AddHttpClient("host", (configureClient) =>
            {
                configureClient.BaseAddress = new Uri(Startup.HostUri);
            }).ConfigurePrimaryHttpMessageHandler(serProvider =>
            {
                var clientHandler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
                };
                return clientHandler;
            });
            return services;
        }
    }
}