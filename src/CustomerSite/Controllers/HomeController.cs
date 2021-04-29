using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace CustomerSite.Controllers
{
    public class HomeController : Controller
    {

        public HomeController() { }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error([FromServices] IExceptionHandlerFeature ex)
        {
            var exception = ex.Error;
            return View(exception);
        }

    }
}
