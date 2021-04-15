using System.Collections.Generic;
using CustomerSite.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;

namespace CustomerSite.Views.Shared.Components.ProductAttribute
{
    [ViewComponent]
    public class ProductAttribute : ViewComponent
    {

        public IProductApiClient _requestProd;

        public ProductAttribute(IProductApiClient requestProd)
        {
            _requestProd = requestProd;
        }

        public IViewComponentResult Invoke(ICollection<ProductAttributeVM> productAttributes)
        {
            // var result = await _requestProd.GetAttributesAsync(productId);
            return View(productAttributes);
        }
    }
}