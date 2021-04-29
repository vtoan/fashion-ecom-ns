using BUS.Interfaces.Services;
using Core.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System.Collections.Generic;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize("Bearer")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderSer;

        public OrderController(IOrderService orderSer)
        {
            _orderSer = orderSer;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public ActionResult<OrderDetailVM> Get(int id)
        {
            var result = _orderSer.Get(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<OrderDetailVM> Create(OrderDetailVM orderDetailVM)
        {
            if (!ModelState.IsValid || orderDetailVM.UserId == null) return BadRequest();
            var result = _orderSer.Add(orderDetailVM);
            if (result == null) return Problem("Can't add new order");
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult<ICollection<OrderVM>> GetList(string start, string end, int provinceId, int limited, int offset)
        {
            if (start == null || end == null) return BadRequest();
            var result = _orderSer.GetList(start, end, provinceId, limited, offset);
            RespHelper.AddTotalPage(HttpContext, result.TotalItem);
            return Ok(result.Orders);
        }

        [HttpGet("phone")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<OrderVM>> GetListByPhone(string phone, int provinceId, int limited, int offset)
        {
            if (string.IsNullOrEmpty(phone) || string.IsNullOrWhiteSpace(phone)) return BadRequest();
            var result = _orderSer.GetListByPhone(phone, provinceId, limited, offset);
            RespHelper.AddTotalPage(HttpContext, result.TotalItem);
            return Ok(result.Orders);
        }

        [HttpGet("user")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<OrderVM>> GetListByUser(string userId, int provinceId, int limited, int offset)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrWhiteSpace(userId)) return BadRequest();
            var result = _orderSer.GetListByUser(userId, provinceId, limited, offset);
            RespHelper.AddTotalPage(HttpContext, result.TotalItem);
            return Ok(result.Orders);
        }
    }
}