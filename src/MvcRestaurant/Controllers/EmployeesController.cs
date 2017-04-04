using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcRestaurant.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Employees";
            return View();
        }
    }
}
