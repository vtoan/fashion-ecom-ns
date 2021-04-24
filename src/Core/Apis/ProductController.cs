using Shared.Enums;
using BUS.Interfaces.Services;
using Core.Helper;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize("Bearer")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productSer;

        private readonly string _imageFolder = "product-images/";

        public ProductController(IProductService productSer)
        {
            _productSer = productSer;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public ActionResult<ProductDetailVM> Get(int id)
        {
            return _productSer.Get(id);
        }

        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<ProductVM> GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort)
        {
            var result = _productSer.GetList(query, typeId, cateId, limited, offset, sort);
            RespHelper.AddTotalPage(HttpContext, result.Total);
            return result.Products;
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult<ProductDetailVM> Create(ProductDetailVM productDetailVM)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _productSer.Add(productDetailVM);
            if (result == null) return Problem("Can't add new product");
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult Update(int id, ProductDetailVM productDetailVM)
        {
            if (id != productDetailVM.Id) return BadRequest();
            var result = _productSer.Update(id, productDetailVM);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var result = _productSer.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }

        // Image
        [HttpGet("{productId}/images")]
        [AllowAnonymous]
        public IEnumerable<string> GetListImage([FromServices] IFileService fileSer, int productId)
        {
            return fileSer.GetFilesInFolder(_imageFolder + productId);
        }

        [HttpPost("{productId}/images")]
        [Authorize(Roles = "admin")]
        public ActionResult<string> UploadImage([FromServices] IFileService fileSer, IFormFile image, int productId)
        {
            return _uploadImage(fileSer, image, productId);
        }

        [HttpDelete("{productId}/images")]
        [Authorize(Roles = "admin")]
        public IActionResult DeleteImage([FromServices] IFileService fileSer, string imageName, int productId)
        {
            if (imageName == null) return BadRequest();
            fileSer.RemoveFile(_imageFolder + productId, imageName);
            return NoContent();
        }

        private string _uploadImage(IFileService fileSer, IFormFile image, int id)
        {
            var fileName = id + "_" + DateTime.Now.Millisecond + "_" + image.FileName;
            fileSer.UploadFileAsync(_imageFolder + id, image, fileName);
            return fileName;
        }
    }
}