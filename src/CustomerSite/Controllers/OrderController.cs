using CustomerSite.Interfaces;
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
        public static readonly string KEY_CART_SESSION = "cart";

        public OrderController(IProductApiClient resquestProd)
        {
            _requestProd = resquestProd;
        }

        [HttpGet("/Order")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/OrderItem")]
        public async Task<IActionResult> OrderAsync(string attrIds)
        {
            var cartItems = await _findListCartItemAsync(attrIds);
            return PartialView("_ListCartItemPartial", cartItems);
        }


        [HttpPost("/Order")]
        public async Task<IActionResult> OrderSubmitAsync([FromForm] string attrIds)
        {
            var cartItems = await _findListCartItemAsync(attrIds);
            HttpContext.Session.SetString(KEY_CART_SESSION, JsonSerializer.Serialize(cartItems));
            return RedirectToAction("Checkout");
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            var items = HttpContext.Session.GetString(KEY_CART_SESSION);
            return View();
        }

        [HttpPost]
        public IActionResult CheckoutSubmit()
        {
            return View();
        }


        private async Task<IEnumerable<CartItemVM>> _findListCartItemAsync(string attrIds)
        {
            if (
                String.IsNullOrWhiteSpace(attrIds)
                || attrIds == "") throw new Exception();
            //
            var cartItems = JsonSerializer.Deserialize<List<CartItemVM>>(attrIds);
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
