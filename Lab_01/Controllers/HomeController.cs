using Lab_01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab_01.Controllers
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
            ViewBag.message = "Chào mừng bạn đến với ASP.NET MVC";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.message = "Đây là trang about";
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
    }
}