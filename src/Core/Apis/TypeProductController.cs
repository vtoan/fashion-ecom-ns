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
    public class TypeProductController : ControllerBase
    {
        private ITypeProductService _typeSer;

        public TypeProductController(ITypeProductService typeSer)
        {
            _typeSer = typeSer;
        }

        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<TypeProductVM> GetList()
        {
            return _typeSer.GetList();
        }
    }
}