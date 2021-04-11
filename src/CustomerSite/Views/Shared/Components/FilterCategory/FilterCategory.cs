using System.Threading.Tasks;
using CustomerSite.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerSite.Views.Shared.Components.FilterCategory
{
    [ViewComponent]
    public class FilterCategory : ViewComponent
    {
        private readonly ICategoryApiClient _request;
        public FilterCategory(ICategoryApiClient request)
        {
            _request = request;
        }

        public async Task<IViewComponentResult> InvokeAsync(int typeId, int cateIdCurrent)
        {
            var result = await _request.GetListAsync(typeId);
            ViewBag.CateCurrent = cateIdCurrent;
            return View(result);
        }
    }
}