using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcDemoII.Models;

namespace MvcDemoII.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(UserInfo user)
        {

            if (user.Email == "ram" && user.Password == "123")
            {
                return View("home",user);
            }
            else
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }
        }

    }
}
