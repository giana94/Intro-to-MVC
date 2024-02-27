using BlockBusterWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlockBusterWebApp.Controllers
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

        public IActionResult Colors()
        {
            string[] colors = { "Purple", "Red", "Yellow" };
            ViewBag.Colors = colors;    
            return View();
        }

        public IActionResult Cities() 
        {
			string[] cities = { "Athens", "Amsterdam", "Marbella", "Edinburgh", "Colorado Springs" };
			ViewBag.Cities = cities;
			return View();
		}

        public IActionResult Hobbies()
        {
			string[] hobbies = { "Rollerskating", "Flag Football", "Dancing", "Painting", "Woodworking" };
			ViewBag.Hobbies = hobbies;
			return View();
		}
    }
}