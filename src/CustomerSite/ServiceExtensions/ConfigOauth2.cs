using System;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace CustomerSite.ServiceExtensions
{
    public static class ConfigOauth2
    {
        public static IServiceCollection AddConfigOauth2(this IServiceCollection services)
        {

            services.AddAuthentication(options =>
             {
                 options.DefaultScheme = "Cookies";
                 options.DefaultChallengeScheme = "oidc";
             })
                 .AddCookie("Cookies")
                 .AddOpenIdConnect("oidc", options =>
                 {
                     options.Authority = "https://localhost:5001";
                     //  options.RequireHttpsMetadata = false;
                     options.GetClaimsFromUserInfoEndpoint = true;

                     options.ClientId = "mvc";
                     options.ClientSecret = "secret";
                     options.ResponseType = "code";

                     options.SaveTokens = true;

                     options.Scope.Add("openid");
                     options.Scope.Add("profile");
                     options.Scope.Add("fashion.client");

                     options.TokenValidationParameters = new TokenValidationParameters
                     {
                         NameClaimType = "name",
                         RoleClaimType = "role"
                     };
                 });
            return services;
        }
    }
}