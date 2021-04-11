using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CustomerSite.Helpful;
using CustomerSite.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Enums;
using Shared.ViewModels;

namespace CustomerSite.Views.Shared.Components.ProductsPreview
{
    [ViewComponent]
    public class ProductsPreviewViewComponent : ViewComponent
    {

        private readonly IProductApiClient _request;
        public ProductsPreviewViewComponent(IProductApiClient request)
        {
            _request = request;
        }

        public async Task<IViewComponentResult> InvokeAsync(EItemPreview eItemPreview)
        {
            var item = HelpperPreview.ItemPreviews[(int)eItemPreview];
            var result = await _request.GetListAsync(null, item.TypeId, 0, item.Limited, 0, ProductSort.Popular);
            ViewBag.Title = item.Title;
            return View(result.Item1);
        }
    }
}