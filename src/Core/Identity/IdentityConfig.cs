using System.Collections.Generic;
using Core.ServiceExtensions;
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
                new ApiScope("fashion.client"),
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "mvc",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { ReadConfig.clientUrls["mvc"] +"/signin-oidc" },
                    FrontChannelLogoutUri = ReadConfig.clientUrls["mvc"] +"/signout-callback-oidc",
                    PostLogoutRedirectUris = { ReadConfig.clientUrls["mvc"] +"/signout-callback-oidc" },

                    AllowOfflineAccess = true,
                    AccessTokenLifetime = 63113904,
                    IdentityTokenLifetime = 63113904,
                    RefreshTokenExpiration = TokenExpiration.Sliding,
                    SlidingRefreshTokenLifetime = 63113904,
                    AllowedScopes = { "openid", "profile", "fashion.client" }
                },
                new Client
                {
                    ClientId = "spa",
                    ClientName = "Reac app",
                    ClientUri = ReadConfig.clientUrls["react"],
                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequireClientSecret = false,
                    RedirectUris =
                    {
                        "http://localhost:3000/signin-oidc",
                    },
                    FrontChannelLogoutUri = ReadConfig.clientUrls["react"]+ "/signout-oidc",
                    PostLogoutRedirectUris = { ReadConfig.clientUrls["react"]+"/signout-callback-oidc" },
                    AllowedCorsOrigins = { ReadConfig.clientUrls["react"] },
                    AllowedScopes = { "openid", "profile", "fashion.client" },
                    AllowAccessTokensViaBrowser = true,
                    AllowOfflineAccess = true,
                    AccessTokenLifetime = 63113904,
                    IdentityTokenLifetime = 63113904,
                    RefreshTokenExpiration = TokenExpiration.Sliding,
                    SlidingRefreshTokenLifetime = 63113904
                }
            };
    }
}