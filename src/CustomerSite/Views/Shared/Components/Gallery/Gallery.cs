using System.Threading.Tasks;
using CustomerSite.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerSite.Views.Shared.Components.Gallery
{
    [ViewComponent]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class Gallery : ViewComponent
    {
        private readonly IProductApiClient _request;
        public Gallery(IProductApiClient request)
        {
            _request = request;
        }

        public async Task<IViewComponentResult> InvokeAsync(int productId, string ImageDefault)
        {
            var result = await _request.GetListImageAsync(productId);
            ViewBag.ImageDefault = ImageDefault;
            return View((result, productId));
        }
    }
}