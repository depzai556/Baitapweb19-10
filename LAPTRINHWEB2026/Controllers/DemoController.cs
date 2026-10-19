using Microsoft.AspNetCore.Mvc;

namespace LAPTRINHWEB2026.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
