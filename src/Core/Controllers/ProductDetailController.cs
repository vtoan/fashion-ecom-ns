using BUS.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductDetailController : ControllerBase
    {
        private readonly IProductDetailService _productDetailSer;

        public ProductDetailController(IProductDetailService productDetailSer)
        {
            _productDetailSer = productDetailSer;
        }

        [HttpGet("{id}")]
        public IEnumerable<ProductAttributeVM> Get(int id)
        {
            return _productDetailSer.GetList(id);
        }
    }
}