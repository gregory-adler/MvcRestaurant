using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcRestaurant.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "MvcRestauarant";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This was made as a project to help me develop my asp .net skills";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Gregory Adler";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
