using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CustomerSite.Interfaces;
using Shared.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace CustomerSite.Controllers
{
    public class RatingController : Controller
    {
        private readonly IRatingApiClient _request;

        public RatingController(IRatingApiClient request)
        {
            _request = request;
        }

        [HttpGet("/rating/{productId}")]
        public IActionResult Index(int productId)
        {
            return Redirect("/product/" + productId);
        }

        [HttpPost("/rating/{productId}")]
        [Authorize]
        public async Task<IActionResult> SubmitAsync(int productId, RatingVM ratingVM)
        {
            if (!ModelState.IsValid) return Redirect("/product/" + productId);
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ratingVM.UserId = userId;
            await _request.CreateAsync(productId, ratingVM);
            ViewBag.ProductId = productId;
            return View("Index");
        }

    }
}
