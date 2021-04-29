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
    public class RatingController : ControllerBase
    {
        private IRatingService _ratingSer;

        public RatingController(IRatingService ratingSer)
        {
            _ratingSer = ratingSer;
        }

        [HttpGet("product/{id}")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<RatingVM>> GetByProduct(int id)
        {
            if (id <= 0) return BadRequest();
            return Ok(_ratingSer.GetByProduct(id));
        }

        [HttpGet("user/{id}")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<RatingVM>> GetByUser(int id)
        {
            if (id <= 0) return BadRequest();
            return Ok(_ratingSer.GetByProduct(id));
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<RatingVM> Create(int productId, RatingVM ratingVM)
        {
            if (!ModelState.IsValid || productId <= 0) return BadRequest();
            var result = _ratingSer.Add(productId, ratingVM);
            if (result == null) return Problem("Can't add rating");
            return CreatedAtAction(nameof(Create), result);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            if (id <= 0) return BadRequest();
            var result = _ratingSer.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}