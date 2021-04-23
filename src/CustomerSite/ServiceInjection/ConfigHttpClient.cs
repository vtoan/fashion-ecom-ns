using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace CustomerSite.ServiceInjection
{
    public static class ConfigHttpClient
    {
        public static IServiceCollection AddConfigHttpClient(this IServiceCollection services, IConfiguration configuration)
        {

            // url
            Startup.HostUri = configuration.GetValue<string>("HostUri");
            Startup.HostProductRes = configuration.GetValue<string>("HostProductRes");

            services.AddHttpContextAccessor();

            services.AddHttpClient("host", (configureClient) =>
            {
                configureClient.BaseAddress = new Uri(Startup.HostUri);
            })
            .ConfigurePrimaryHttpMessageHandler(serProvider =>
            {
                var clientHandler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true,
                };
                return clientHandler;
            })
                .ConfigureHttpClient(async (serProvider, httpClient) =>
               {
                   var httpContext = serProvider.GetRequiredService<IHttpContextAccessor>().HttpContext;
                   var accessToken = await httpContext.GetTokenAsync("access_token");
                   if (accessToken != null)
                       httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
               });
            return services;
        }
    }
}