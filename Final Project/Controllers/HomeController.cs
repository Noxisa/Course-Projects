using System.Diagnostics;
using Final_Project.Models;
using Final_Project.Views.Home;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
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

        public IActionResult Forms()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View(new LoginModel());
        }

        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult ForgotPassword()
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
