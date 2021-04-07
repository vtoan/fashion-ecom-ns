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
        private IFeeService _feeSer;

        public CategoryController(IFeeService feeService)
        {
            _feeSer = feeService;
        }


        [HttpGet]
        public IEnumerable<FeeVM> GetFees()
        {
            return _feeSer.GetList();
        }
    }
}