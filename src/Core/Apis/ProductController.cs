using Shared.Enums;
using BUS.Interfaces.Services;
using Core.Helper;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System;
using System.Collections.Generic;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    // [Authorize("Bearer")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productSer;

        private readonly string _imageFolder = "product-img/";

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
            RespHelper.AddTotalPage(HttpContext, result.Total);
            return result.Products;
        }

        [HttpPost]
        public ActionResult<ProductDetailVM> Create(ProductDetailVM productDetailVM)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _productSer.Add(productDetailVM);
            if (result == null) return Problem("Can't add new product");
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

        // Image
        [HttpGet("{id}/images")]
        public IEnumerable<string> GetListImage([FromServices] IFileService fileSer, int id)
        {
            return fileSer.GetFilesInFolder(_imageFolder + id);
        }

        [HttpPost("{id}/images")]
        public IActionResult UploadImage([FromServices] IFileService fileSer, IFormFile image, int id)
        {
            var fileName = _updateImage(fileSer, image, id);
            return NoContent();
        }

        [HttpPut("{id}/images")]
        public IActionResult ChangeImageDefault([FromServices] IFileService fileSer, IFormFile image, int id)
        {
            var fileName = _updateImage(fileSer, image, id);
            _productSer.SetImageDefault(id, fileName);
            return NoContent();
        }

        private string _updateImage(IFileService fileSer, IFormFile image, int id)
        {
            var fileName = id + "_" + DateTime.Now.Millisecond;
            fileSer.UploadFile(_imageFolder + id, image, fileName);
            return fileName;
        }
    }
}