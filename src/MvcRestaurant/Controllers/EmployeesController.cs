﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcRestaurant.Models;
using Microsoft.AspNetCore.Mvc;

namespace MvcRestaurant.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesRepository _employeesRepository;
        public EmployeesController(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        public async Task<IActionResult> Index()
        {
            var employees = _employeesRepository.getEmployees();
            return View(await employees);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
