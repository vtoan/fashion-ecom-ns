using BUS.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize("Bearer")]
    public class FeeController : ControllerBase
    {
        private IFeeService _feeSer;

        public FeeController(IFeeService feeSer)
        {
            _feeSer = feeSer;
        }

        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<FeeVM> GetList()
        {
            return _feeSer.GetList();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public ActionResult<FeeVM> Get(int id)
        {
            if (id <= 0) return BadRequest();
            var result = _feeSer.Get(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult<FeeVM> Create(FeeVM feeVM)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _feeSer.Add(feeVM);
            if (result == null) return Problem("Can't add new fee");
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult Update(int id, FeeVM feeVM)
        {
            if (id != feeVM.Id) return BadRequest();
            var result = _feeSer.Update(id, feeVM);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var result = _feeSer.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}