using BUS.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;
using System.Text.Json;

namespace Core.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductAttrController : ControllerBase
    {
        private readonly IProductAttrService _productAttrSer;

        public ProductAttrController(IProductAttrService productAttrSer)
        {
            _productAttrSer = productAttrSer;
        }

        [HttpGet("{productId}/attrs")]
        public IEnumerable<ProductAttributeVM> GeList(int productId)
        {
            return _productAttrSer.GetList(productId);
        }

        [HttpGet("attrs")]
        public IEnumerable<OrderItemVM> GeListCartItem(string attrIds)
        {
            var arrAttribute = JsonSerializer.Deserialize<int[]>(attrIds);
            return _productAttrSer.GetListCartItem(arrAttribute);
        }

        [HttpPost("{productId}/attrs")]
        public IActionResult Create(int productId, ProductAttributeVM attributeVM)
        {
            if (!ModelState.IsValid || productId <= 0) return BadRequest();
            var result = _productAttrSer.Add(productId, attributeVM);
            if (result == null) return Problem("Can't add new product attribute");
            return CreatedAtAction(nameof(GeList), result);
        }

        [HttpPut("{productId}/attrs/{id}")]
        public IActionResult Update(int id, ProductAttributeVM attributeVM)
        {
            if (id != attributeVM.Id) return BadRequest();
            var result = _productAttrSer.Update(id, attributeVM);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{productId}/attrs")]
        public IActionResult Delete(int productId)
        {
            var result = _productAttrSer.Delete(productId);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}