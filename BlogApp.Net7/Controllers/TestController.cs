using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Net7.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
