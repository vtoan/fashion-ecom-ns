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
                new ApiScope("admin"),
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
                new Client
                {
                    // unique ID for this client
                    ClientId = "spa", 
                    // human-friendly name displayed in IS
                    ClientName = "Reac app", 
                    // URL of client
                    ClientUri = "http://localhost:3000", 
                    // how client will interact with our identity server (Implicit is basic flow for web apps)
                    AllowedGrantTypes = GrantTypes.Implicit, 
                    // don't require client to send secret to token endpoint
                    RequireClientSecret = false,
                    RedirectUris =
                    {             
                        // can redirect here after login                     
                        "http://localhost:3000/signin-oidc",
                    },
                    FrontChannelLogoutUri = "http://localhost:3000/signout-oidc",
                    // can redirect here after logout
                    PostLogoutRedirectUris = { "http://localhost:3000/signout-oidc" }, 
                    // builds CORS policy for javascript clients
                    AllowedCorsOrigins = { "http://localhost:3000" }, 
                    // what resources this client can access
                    AllowedScopes = { "openid", "profile", "customer" }, 
                    // client is allowed to receive tokens via browser
                    AllowAccessTokensViaBrowser = true
                }
            };
    }
}