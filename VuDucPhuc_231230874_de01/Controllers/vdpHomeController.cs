using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VuDucPhuc_231230874_de01.Models;

namespace VuDucPhuc_231230874_de01.Controllers
{
    public class vdpHomeController : Controller
    {
        private readonly ILogger<vdpHomeController> _logger;

        public vdpHomeController(ILogger<vdpHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult vdpIndex()
        {
            return View();
        }

        public IActionResult vdpPrivacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
