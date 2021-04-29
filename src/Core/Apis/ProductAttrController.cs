using BUS.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;
using System.Text.Json;

namespace Core.Controllers
{
    [ApiController]
    [Route("product")]
    [Authorize("Bearer")]
    public class ProductAttrController : ControllerBase
    {
        private readonly IProductAttrService _productAttrSer;

        public ProductAttrController(IProductAttrService productAttrSer)
        {
            _productAttrSer = productAttrSer;
        }

        [HttpGet("{productId}/attrs")]
        [AllowAnonymous]
        public IEnumerable<ProductAttributeVM> GeList(int productId)
        {
            return _productAttrSer.GetList(productId);
        }

        [HttpGet("attrs")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<OrderItemVM>> GeListCartItem(string attrIds)
        {
            if (string.IsNullOrEmpty(attrIds) || string.IsNullOrWhiteSpace(attrIds)) return BadRequest();
            var arrAttribute = JsonSerializer.Deserialize<int[]>(attrIds);
            return Ok(_productAttrSer.GetListCartItem(arrAttribute));
        }

        [HttpPost("{productId}/attrs")]
        [Authorize(Roles = "admin")]
        public IActionResult Create(int productId, ProductAttributeVM attributeVM)
        {
            if (!ModelState.IsValid || productId <= 0) return BadRequest();
            var result = _productAttrSer.Add(productId, attributeVM);
            if (result == null) return Problem("Can't add new product attribute");
            return CreatedAtAction(nameof(GeList), result);
        }

        [HttpPut("{productId}/attrs/{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult Update(int id, ProductAttributeVM attributeVM)
        {
            if (id != attributeVM.Id) return BadRequest();
            var result = _productAttrSer.Update(id, attributeVM);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{productId}/attrs/{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            if (id <= 0) return BadRequest();
            var result = _productAttrSer.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}