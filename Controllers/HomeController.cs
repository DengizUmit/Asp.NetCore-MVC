using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}