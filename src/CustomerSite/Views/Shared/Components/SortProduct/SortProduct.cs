using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shared.Enums;

namespace CustomerSite.Views.Shared.Components.SortProduct
{
    [ViewComponent]
    public class SortProduct : ViewComponent
    {

        public IViewComponentResult Invoke(int typeId, int cateId, ProductSort? sortCurrent)
        {
            ViewBag.CateId = cateId;
            ViewBag.TypeId = typeId;
            ViewBag.SortCurrent = sortCurrent;
            return View();
        }
    }
}