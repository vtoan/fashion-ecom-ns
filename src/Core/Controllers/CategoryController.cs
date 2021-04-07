using BUS.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _cateSer;

        public CategoryController(ICategoryService cateSer)
        {
            _cateSer = cateSer;
        }

        [HttpGet]
        public IEnumerable<CategoryVM> GetList(int typeId)
        {
            if (typeId == 0) return _cateSer.GetList();
            return _cateSer.GetList(typeId);
        }

        [HttpGet("{id}")]
        public ActionResult<CategoryVM> Get(int id)
        {
            if (id <= 0) return BadRequest();
            var result = _cateSer.Get(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost]
        public ActionResult<CategoryVM> Create(CategoryVM categoryVM)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _cateSer.Add(categoryVM);
            if (result == null) return BadRequest();
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoryVM categoryVM)
        {
            if (id != categoryVM.Id) return BadRequest();
            var result = _cateSer.Update(id, categoryVM);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _cateSer.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}