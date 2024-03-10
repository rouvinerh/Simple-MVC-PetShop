using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using System.Diagnostics;

namespace PetShop.Controllers
{
    public class DisclaimerController : Controller
    {
        private readonly ILogger<DisclaimerController> _logger;

        public DisclaimerController(ILogger<DisclaimerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
