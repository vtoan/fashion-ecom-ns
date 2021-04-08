using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CustomerSite.Helpful;
using CustomerSite.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;

namespace CustomerSite.Views.Shared.Components.ProductsPreview
{
    [ViewComponent]
    public class ProductsPreviewViewComponent : ViewComponent
    {

        private readonly IRequestAPI _request;
        public ProductsPreviewViewComponent(IRequestAPI request)
        {
            _request = request;
        }

        public async Task<IViewComponentResult> InvokeAsync(EItemPreview eItemPreview)
        {
            var item = HelpperPreview.ItemPreviews[(int)eItemPreview];
            var result = await _request.GetAsync<List<ProductVM>>(item.RequestUrl);
            return View(result);
        }
    }
}