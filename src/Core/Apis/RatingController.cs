using BUS.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RatingController : ControllerBase
    {
        private IRatingService _ratingSer;

        public RatingController(IRatingService ratingSer)
        {
            _ratingSer = ratingSer;
        }

        [HttpGet("product/{id}")]
        public IEnumerable<RatingVM> GetByProduct(int id)
        {
            return _ratingSer.GetByProduct(id);
        }

        [HttpGet("user/{id}")]
        public IEnumerable<RatingVM> GetByUser(int id)
        {
            return _ratingSer.GetByProduct(id);
        }

        [HttpPost]
        public ActionResult<FeeVM> Create(int productId, string userId, RatingVM ratingVM)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _ratingSer.Add(productId, ratingVM);
            if (result == null) return Problem("Can't add rating");
            return CreatedAtAction(nameof(Create), result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _ratingSer.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}