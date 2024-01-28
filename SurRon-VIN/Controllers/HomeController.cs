using Microsoft.AspNetCore.Mvc;
using SurRon_VIN.Models;
using System.Diagnostics;

namespace SurRon_VIN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string OpenModelPopup()
        {
            //can send some data also.  
            return "<h1>This is Modal Popup Window</h1>";
        }
    }
}
