using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(); //Views - Home - Index.cshtml
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View(); //Views - Home - Privacy.cshtml
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View(); // Views - Home - Contact.cshtml
        }

    }
}