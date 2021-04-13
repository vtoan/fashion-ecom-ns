using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;

namespace CustomerSite.Views.Shared.Components.ProductAttribute
{
    [ViewComponent]
    public class ProductAttribute : ViewComponent
    {
        public IViewComponentResult Invoke(ICollection<ProductAttributeVM> productAttributes)
        {
            return View(productAttributes);
        }
    }
}