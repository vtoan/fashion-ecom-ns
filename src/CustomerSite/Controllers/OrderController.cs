using CustomerSite.Helpful;
using CustomerSite.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerSite.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductApiClient _requestProd;

        public OrderController(IProductApiClient resquestProd)
        {
            _requestProd = resquestProd;
        }

        [HttpGet("/Order")]
        public async Task<IActionResult> IndexAsync([FromServices] IOrderApiClient requestOrder)
        {
            var fees = await requestOrder.GetListFeeAsync();
            ViewBag.Fees = fees;
            return View();
        }

        [HttpGet("/OrderItem")]
        public async Task<IActionResult> OrderAsync(string attrIds)
        {
            var cartItems = await _findListCartItemAsync(attrIds);
            return PartialView("_ListCartItemPartial", cartItems);
        }

        [HttpPost("/Order")]
        [Authorize]
        public async Task<IActionResult> OrderSubmitAsync(string attrIds)
        {
            var cartItems = await _findListCartItemAsync(attrIds);
            HttpContext.Session.SetString(PageHelper.KEY_CART_SESSION, JsonSerializer.Serialize(cartItems));
            return Redirect("/Checkout");
        }

        private async Task<IEnumerable<OrderItemVM>> _findListCartItemAsync(string attrIds)
        {
            if (
                String.IsNullOrWhiteSpace(attrIds)
                || String.IsNullOrEmpty(attrIds)) throw new Exception("Can't get order items");
            //
            var cartItems = JsonSerializer.Deserialize<List<OrderItemVM>>(attrIds);
            var arrAttrIds = cartItems.Select(item => item.AttributeId);
            var json = JsonSerializer.Serialize(arrAttrIds);
            var listCartItem = await _requestProd.GetListCartItemsAsync(json);
            //
            foreach (var item in listCartItem)
            {
                var arrId = item.AttributeId;
                var root = cartItems.Find(item => item.AttributeId == arrId);
                item.Quantity = root.Quantity;
            }
            return listCartItem;
        }
    }
}
