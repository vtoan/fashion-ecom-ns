using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using BUS.Domains;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using IdentityServer4.Services;

namespace Core.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<LogoutModel> _logger;

        private readonly IIdentityServerInteractionService _interaction;


        public LogoutModel(SignInManager<User> signInManager, ILogger<LogoutModel> logger, IIdentityServerInteractionService interaction)
        {
            _signInManager = signInManager;
            _interaction = interaction;
            _logger = logger;
        }

        public async Task<IActionResult> OnGet(string returnUrl = null)
        {
            return await this.OnPost(returnUrl);
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");

            var logoutId = this.Request.Query["logoutId"].ToString();
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else if (!string.IsNullOrEmpty(logoutId))
            {
                var logoutContext = await this._interaction.GetLogoutContextAsync(logoutId);
                returnUrl = logoutContext.PostLogoutRedirectUri;

                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return this.Redirect(returnUrl);
                }
                else
                {
                    return Page();
                }
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
