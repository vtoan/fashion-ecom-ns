using BUS.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;

namespace Core.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductDetailController : ControllerBase
    {
        private readonly IProductDetailService _productDetailSer;

        public ProductDetailController(IProductDetailService productDetailSer)
        {
            _productDetailSer = productDetailSer;
        }

        [HttpGet("{productId}/attrs")]
        public IEnumerable<ProductAttributeVM> GeList(int productId)
        {
            return _productDetailSer.GetList(productId);
        }

        [HttpPost("{productId}/attrs")]
        public IActionResult Create(int productId, ProductAttributeVM attributeVM)
        {
            if (!ModelState.IsValid || productId <= 0) return BadRequest();
            var result = _productDetailSer.Add(productId, attributeVM);
            if (result == null) return Problem();
            return CreatedAtAction(nameof(GeList), result);
        }

        [HttpPut("{productId}/attrs/{id}")]
        public IActionResult Update(int id, ProductAttributeVM attributeVM)
        {
            if (id != attributeVM.Id) return BadRequest();
            var result = _productDetailSer.Update(id, attributeVM);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _productDetailSer.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}