using CustomerSite.Helpful;
using CustomerSite.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerSite.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly IOrderApiClient _requestOrder;
        public CheckoutController(IOrderApiClient requestOrder)
        {
            _requestOrder = requestOrder;
        }

        [HttpGet("/Checkout")]
        public async Task<IActionResult> CheckoutAsync()
        {
            var listOrderItem = _getOrderItemsInSession(HttpContext);
            if (listOrderItem == null) return Redirect("/Order");
            //
            var fees = await _requestOrder.GetListFeeAsync();
            HttpContext.Session.SetString(PageHelper.KEY_FEE_SESSION, JsonSerializer.Serialize(fees));
            ViewBag.Fees = fees;
            return View("Index", listOrderItem);
        }


        [HttpPost("/Checkout")]
        public async Task<IActionResult> CheckoutSubmitAsync(OrderDetailVM orderDetailVM)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var listOrderItem = _getOrderItemsInSession(HttpContext);
            if (listOrderItem == null) return Redirect("/Order");
            //
            var fees = HttpContext.Session.GetString(PageHelper.KEY_FEE_SESSION);
            orderDetailVM.Fees = fees;
            orderDetailVM.UserId = userId;
            var result = await _requestOrder.CreateAsync(orderDetailVM, listOrderItem);
            // listCartItem 
            if (result == null) Redirect("/Error");
            return View("~/Views/Home/Ordered.cshtml");
        }

        private List<OrderItemVM> _getOrderItemsInSession(HttpContext httpContext)
        {
            var items = HttpContext.Session.GetString(PageHelper.KEY_CART_SESSION);
            if (items == null || items == "") return null;
            var listOrderItem = JsonSerializer.Deserialize<List<OrderItemVM>>(items);
            if (listOrderItem == null || listOrderItem.Count == 0) return null;
            return listOrderItem;
        }
    }
}
