using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CustomerSite.Models;
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

        [HttpGet("/product/{typeId}")]
        public async Task<IActionResult> ListProductAsync(string query = null, int typeId = 0, int cateId = 0, int page = 1, ProductSort? sort = null)
        {
            var resp = await _request.GetList(query, typeId, cateId, _pageSize, page - 1, sort);
            ViewBag.TypeId = typeId;
            ViewBag.Sort = sort;
            ViewBag.CateId = cateId;
            ViewBag.Total = resp.Item2;
            ViewBag.Page = Math.Ceiling(resp.Item2 / (_pageSize + 0.0));
            ViewBag.PageCurrent = page;
            return View(resp.Item1);
        }



    }
}
