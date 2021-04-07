using BUS.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeeController : ControllerBase
    {
        private IFeeService _feeSer;

        public FeeController(IFeeService feeSer)
        {
            _feeSer = feeSer;
        }

        [HttpGet]
        public IEnumerable<FeeVM> GetList()
        {
            return _feeSer.GetList();
        }

        [HttpGet("{id}")]
        public ActionResult<FeeVM> Get(int id)
        {
            if (id <= 0) return BadRequest();
            var result = _feeSer.Get(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost]
        public ActionResult<FeeVM> Create(FeeVM feeVM)
        {
            var result = _feeSer.Add(feeVM);
            if (result == null) return BadRequest();
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, FeeVM feeVM)
        {
            if (id != feeVM.Id) return BadRequest();
            var result = _feeSer.Update(id, feeVM);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _feeSer.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}