using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CustomerSite.Models;
using CustomerSite.Interfaces;
using Shared.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;

namespace CustomerSite.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/" }, "oidc");
        }

        public new IActionResult SignOut()
        {
            return SignOut(new AuthenticationProperties { RedirectUri = "/" }, "Cookies", "oidc");
        }
    }
}
