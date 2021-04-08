using BUS.Enums;
using BUS.Interfaces.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;
using System.IO;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productSer;

        public ProductController(IProductService productSer)
        {
            _productSer = productSer;
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDetailVM> Get(int id)
        {
            return _productSer.Get(id);
        }

        [HttpGet]
        public IEnumerable<ProductVM> GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort)
        {
            var result = _productSer.GetList(query, typeId, cateId, limited, offset, sort);
            HttpContext.Response.Headers.Add("total-item", result.Item2.ToString());
            return result.Item1;
        }

        [HttpPost]
        public ActionResult<ProductDetailVM> Create(ProductDetailVM productDetailVM)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _productSer.Add(productDetailVM);
            if (result == null) return BadRequest();
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductDetailVM productDetailVM)
        {
            if (id != productDetailVM.Id) return BadRequest();
            var result = _productSer.Update(id, productDetailVM);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _productSer.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }

        //Image
        [HttpGet("{id}/images")]
        public IEnumerable<string> GetListImage([FromServices] IWebHostEnvironment environment, int id)
        {
            var webRootPath = environment.WebRootPath;
            var folderPath = Path.Combine(webRootPath, "product-image/" + id);
            return _productSer.GetImages(id, folderPath);
        }



    }
}