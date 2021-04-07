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

        [HttpGet("{id}")]
        public IEnumerable<RatingVM> Get(int id)
        {
            return _ratingSer.GetByProduct(id);
        }
    }
}