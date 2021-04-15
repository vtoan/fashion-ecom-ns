using System.Threading.Tasks;
using CustomerSite.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static CustomerSite.Controllers.ProductController;

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

        public async Task<IViewComponentResult> InvokeAsync(ProdPageParam prodPageParam)
        {
            var result = await _request.GetListAsync(prodPageParam.typeId);
            ViewBag.ProdPageParam = prodPageParam;
            return View(result);
        }
    }
}