using System.Collections.Generic;
using IdentityServer4.Models;

namespace Core.Identity
{
    public class IdentityConfig
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                   };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("customer"),
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "mvc",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { "https://localhost:6001/signin-oidc" },
                    FrontChannelLogoutUri = "https://localhost:6001/signout-oidc",
                    PostLogoutRedirectUris = { "https://localhost:6001/signout-callback-oidc" },


                    AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile", "customer" }
                },
            };
    }
}