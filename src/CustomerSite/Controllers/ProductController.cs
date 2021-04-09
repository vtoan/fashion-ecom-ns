using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CustomerSite.Models;

namespace CustomerSite.Controllers
{
    public class ProductController : Controller
    {

        public ProductController() { }

        public IActionResult ListProduct()
        {
            return View();
        }

    }
}
