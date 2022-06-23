using Microsoft.AspNetCore.Mvc;
using MyProfileWebsite.Models;
using System.Diagnostics;

namespace MyProfileWebsite.Controllers
{
    public class ProfileHomeController : Controller
    {
        private readonly ILogger<ProfileHomeController> _logger;

        public ProfileHomeController(ILogger<ProfileHomeController> logger)
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
    }
}