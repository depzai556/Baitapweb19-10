using Microsoft.AspNetCore.Mvc;

namespace DuAn.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
