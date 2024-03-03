using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PetShop.Controllers
{
    public class WelcomeController : Controller
    {
        // /Welcome/Index
        public IActionResult Index()
        {
            return View();
        }

        // /Welcome/Hello
        public IActionResult Hello(String name, int id = 1)
        {
            ViewData["name"] = name;
            ViewData["greeting"] = "Hello " + name;
            ViewData["id"] = id;
            return View();
        }
    }
}
