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
using Core.Models;

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
            var result = _productSer.Get(id);
            if (result == null) return NotFound();
            return result;
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
            if (id <= 0) return BadRequest();
            var result = _productSer.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }

        // Image
        [HttpGet("{productId}/images")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<string>> GetListImage([FromServices] IFileService fileSer, int productId)
        {
            if (productId <= 0) return BadRequest();
            return Ok(fileSer.GetFilesInFolder(_imageFolder + productId));
        }

        [HttpPost("{productId}/images")]
        [Authorize(Roles = "admin")]
        public ActionResult<string> UploadImage([FromServices] IFileService fileSer, IFormFile image, int productId)
        {
            if (image == null || productId <= 0) return BadRequest();
            return _uploadImage(fileSer, image, productId);
        }

        [HttpPut("{productId}/images")]
        [Authorize(Roles = "admin")]
        public ActionResult<string> ChangeDefaultImage([FromServices] IFileService fileSer, int productId, ProductImageModel imageModel)
        {
            if (!ModelState.IsValid || productId <= 0) return BadRequest();
            // var fileExsist = fileSer.CheckFileExsist(_imageFolder, imageModel.Image);
            // if (!fileExsist) return NotFound();
            var result = _productSer.Update(imageModel.Id, new ProductDetailVM() { Id = imageModel.Id, Image = imageModel.Image });
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{productId}/images")]
        [Authorize(Roles = "admin")]
        public IActionResult DeleteImage([FromServices] IFileService fileSer, string imageName, int productId)
        {
            if (imageName == null || productId <= 0) return BadRequest();
            fileSer.RemoveFile(_imageFolder, imageName);
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