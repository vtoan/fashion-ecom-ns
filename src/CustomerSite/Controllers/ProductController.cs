using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shared.Enums;
using CustomerSite.Interfaces;

namespace CustomerSite.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _request;

        private readonly int _pageSize = 8;

        public ProductController(IProductApiClient request)
        {
            _request = request;
        }

        [HttpGet("/type/{typeId}")]
        public async Task<IActionResult> ListProductAsync(string query = null, int typeId = 0, int cateId = 0, int page = 1, ProductSort? sort = null)
        {
            var resp = await _request.GetListAsync(query, typeId, cateId, _pageSize, page - 1, sort);
            ViewBag.TypeId = typeId;
            ViewBag.Sort = sort;
            ViewBag.CateId = cateId;
            ViewBag.Total = resp.TotalItem;
            //
            ViewBag.Page = Math.Ceiling(resp.TotalItem / (_pageSize + 0.0));
            ViewBag.PageCurrent = page;
            return View(resp.Products);
        }

        [HttpGet("product/{productId}")]
        public async Task<IActionResult> ProductDetailAsync(int productId)
        {
            var resp = await _request.GetAsync(productId);
            return View(resp);
        }
    }
}
