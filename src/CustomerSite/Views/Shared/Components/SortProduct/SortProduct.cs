using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static CustomerSite.Controllers.ProductController;

namespace CustomerSite.Views.Shared.Components.SortProduct
{
    [ViewComponent]
    public class SortProduct : ViewComponent
    {

        public IViewComponentResult Invoke(ProdPageParam prodPageParam)
        {
            ViewBag.ProdPageParam = prodPageParam;
            return View();
        }
    }
}