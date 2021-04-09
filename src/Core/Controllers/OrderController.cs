using BUS.Interfaces.Services;
using Core.Helper;
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

        [HttpPost("{id}")]
        public OrderDetailVM Create(int id)
        {
            return _orderSer.Get(id);
        }

        [HttpGet]
        public ActionResult<ICollection<OrderVM>> GetList(string start, string end, int provinceId, int limited, int offset)
        {
            if (start == null || end == null) return BadRequest();
            var result = _orderSer.GetList(start, end, provinceId, limited, offset);
            RespHelper.AddTotalPage(HttpContext, result.Item2);
            return Ok(result.Item1);
        }

        [HttpGet("phone")]
        public IEnumerable<OrderVM> GetListByPhone(string query, int provinceId, int limited, int offset)
        {
            var result = _orderSer.GetListByPhone(query, provinceId, limited, offset);
            RespHelper.AddTotalPage(HttpContext, result.Item2);
            return result.Item1;
        }

        [HttpGet("user")]
        public IEnumerable<OrderVM> GetListByUser(string userId, int provinceId, int limited, int offset)
        {
            var result = _orderSer.GetListByUser(userId, provinceId, limited, offset);
            RespHelper.AddTotalPage(HttpContext, result.Item2);
            return result.Item1;
        }
    }
}