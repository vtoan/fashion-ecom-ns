using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        [HttpGet("/home/error")]
        public IActionResult Error(string errorId)
        {
            return Problem(errorId);
        }
    }
}