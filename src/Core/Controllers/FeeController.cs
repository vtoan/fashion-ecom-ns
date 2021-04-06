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

        public FeeController(IFeeService feeService)
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