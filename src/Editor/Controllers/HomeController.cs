using Microsoft.AspNetCore.Mvc;

namespace Editor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
