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
        private ICategoryService _cateSer;

        public FeeController(ICategoryService cateService)
        {
            _cateSer = cateService;
        }


        [HttpGet]
        public IEnumerable<CategoryVM> GetFees()
        {
            return _cateSer.GetList();
        }
    }
}