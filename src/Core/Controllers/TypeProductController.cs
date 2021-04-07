using BUS.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TypeProductController : ControllerBase
    {
        private ITypeProductService _typeSer;

        public TypeProductController(ITypeProductService typeSer)
        {
            _typeSer = typeSer;
        }


        [HttpGet]
        public IEnumerable<TypeProductVM> GetList()
        {
            return _typeSer.GetList();
        }
    }
}