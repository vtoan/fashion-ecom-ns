using BUS.Domains;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Identity
{
    public static class IdentityConfigService
    {
        public static IServiceCollection AddIdentityServer4(this IServiceCollection services)
        {

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
               .AddAspNetIdentity<User>();
            builder.AddDeveloperSigningCredential();

            //authen
            services
                .AddAuthentication()
                .AddLocalApi("Bearer", options =>
                {
                    options.ExpectedScope = "scope1";
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