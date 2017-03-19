using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcRestaurant.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcRestaurant.Controllers
{
    public class CreateRestaurant : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Server test = new Server("the");
            return View();
        }
    }
}
