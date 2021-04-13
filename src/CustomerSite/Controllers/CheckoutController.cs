using CustomerSite.Helpful;
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
            var items = HttpContext.Session.GetString(PageHelper.KEY_CART_SESSION);
            if (items == null || items == "") return Redirect("/Order");
            var listCartItem = JsonSerializer.Deserialize<IEnumerable<CartItemVM>>(items);
            if (listCartItem == null || listCartItem.Count() <= 0) return Redirect("/Order");
            var fees = await _requestOrder.GetListFeeAsync();
            //
            HttpContext.Session.SetString(PageHelper.KEY_FEE_SESSION, JsonSerializer.Serialize(fees));
            ViewBag.Fees = fees;
            return View("Index", listCartItem);
        }


        [HttpPost("/Checkout")]
        public async Task<IActionResult> CheckoutSubmitAsync(OrderDetailVM orderDetailVM)
        {
            var items = HttpContext.Session.GetString(PageHelper.KEY_CART_SESSION);
            var fees = HttpContext.Session.GetString(PageHelper.KEY_FEE_SESSION);
            //  =======get user id;
            var listCartItem = JsonSerializer.Deserialize<List<CartItemVM>>(items);
            orderDetailVM.Fees = fees;
            var listOrderItem = new List<OrderItemVM>();
            foreach (var item in listCartItem)
            {
                listOrderItem.Add(new OrderItemVM
                {
                    ProductId = item.ProductId,
                    Price = item.Price,
                    Quantity = item.Quantity
                });
            }
            var result = await _requestOrder.CreateAsync(orderDetailVM, listOrderItem);
            // listCartItem 
            if (result == null) Redirect("/Error");
            return View("~/Views/Home/Ordered.cshtml");
        }
    }
}
