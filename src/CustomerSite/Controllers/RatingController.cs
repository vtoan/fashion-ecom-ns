using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CustomerSite.Models;
using CustomerSite.Interfaces;
using Shared.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace CustomerSite.Controllers
{
    public class RatingController : Controller
    {
        private readonly IRatingApiClient _request;

        public RatingController(IRatingApiClient request)
        {
            _request = request;
        }

        [HttpPost("/rating/{productId}")]
        public IActionResult Submit(int productId, RatingVM ratingVM)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "unknown";
            // _request.CreateAsync(productId, userId, ratingVM);
            ViewBag.ProductId = productId;
            return View("Index");
        }

    }
}
