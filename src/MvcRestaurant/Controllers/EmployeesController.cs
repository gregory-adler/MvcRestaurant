using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcRestaurant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


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

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
           [Bind("Name,StartDate,DiscriminatorValue")] Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _employeesRepository.createEmployee(employee);
                    return RedirectToAction("Index");
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(employee);
        }
    }
}
