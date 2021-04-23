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

        public class ProdPageParam
        {
            [FromRoute]
            public int typeId { get; set; }

            [FromQuery]
            public string query { get; set; }
            [FromQuery]

            public int cateId { get; set; }
            [FromQuery]

            public int page { get; set; } = 1;
            [FromQuery]

            public ProductSort? sort { get; set; }
        }

        [HttpGet("/type/{typeId}")]
        public async Task<IActionResult> ListProductAsync(ProdPageParam prodPageParam)
        {
            var resp = await _request.GetListAsync(prodPageParam.query, prodPageParam.typeId, prodPageParam.cateId, _pageSize, prodPageParam.page - 1, prodPageParam.sort);
            ViewBag.ProdPageParam = prodPageParam;
            //
            ViewBag.Total = resp.TotalItem;
            ViewBag.Page = Math.Ceiling(resp.TotalItem / (_pageSize + 0.0));
            return View(resp.Products);
        }

        [HttpGet("/search")]
        public async Task<IActionResult> ListProductSearchAsync(ProdPageParam prodPageParam)
        {
            var resp = await _request.GetListAsync(prodPageParam.query, prodPageParam.typeId, prodPageParam.cateId, _pageSize, prodPageParam.page - 1, prodPageParam.sort);
            ViewBag.ProdPageParam = prodPageParam;
            //
            ViewBag.Total = resp.TotalItem;
            ViewBag.Page = Math.Ceiling(resp.TotalItem / (_pageSize + 0.0));
            return View("ListProduct", resp.Products);
        }

        [HttpGet("/product/{productId}")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> ProductDetailAsync(int productId)
        {
            var resp = await _request.GetAsync(productId);
            return View(resp);
        }
    }
}
