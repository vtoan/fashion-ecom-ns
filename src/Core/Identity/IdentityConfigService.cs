using System;
using System.IdentityModel.Tokens.Jwt;
using BUS.Domains;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Identity
{
    public static class IdentityConfigService
    {
        public static IServiceCollection AddIdentityServer4(this IServiceCollection services)
        {

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 0;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;

                options.SignIn.RequireConfirmedEmail = false;
            });

            var builder = services.AddIdentityServer(options =>
           {
               options.Events.RaiseErrorEvents = true;
               options.Events.RaiseInformationEvents = true;
               options.Events.RaiseFailureEvents = true;
               options.Events.RaiseSuccessEvents = true;
               options.EmitStaticAudienceClaim = true;
           })
               .AddInMemoryIdentityResources(IdentityConfig.IdentityResources)
               .AddInMemoryApiScopes(IdentityConfig.ApiScopes)
               .AddInMemoryClients(IdentityConfig.Clients)
               .AddAspNetIdentity<User>()
                .AddProfileService<CustomProfileService>();


            builder.AddDeveloperSigningCredential();

            //authen
            services
                .AddAuthentication()
                .AddLocalApi("Bearer", options =>
                {
                    options.ExpectedScope = "fashion.client";
                });

            //author
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Bearer", policy =>
                {
                    policy.AddAuthenticationSchemes("Bearer");
                    policy.RequireAuthenticatedUser();
                });

            });
            return services;
        }
    }
}