using BUS.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderSer;

        public OrderController(IOrderService orderSer)
        {
            _orderSer = orderSer;
        }

        [HttpGet("{id}")]
        public OrderDetailVM Get(int id)
        {
            return _orderSer.Get(id);
        }
    }
}