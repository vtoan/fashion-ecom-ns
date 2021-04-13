using System.Threading.Tasks;
using CustomerSite.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerSite.Views.Shared.Components.Feedback
{
    [ViewComponent]
    public class Feedback : ViewComponent
    {
        private readonly IRatingApiClient _request;
        public Feedback(IRatingApiClient request)
        {
            _request = request;
        }

        public async Task<IViewComponentResult> InvokeAsync(int productId)
        {
            var result = await _request.GetByProductAsync(productId);
            return View((result, productId));
        }
    }
}