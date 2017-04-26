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
        public IActionResult CreateHost()
        {
            return View();
        }
        public IActionResult CreateServer()
        {
            return View();
        }

        // POST: Employees/CreateHost
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateHost(
           [Bind("Name,StartDate")] Host host)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _employeesRepository.createHost(host);
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
            return View(host);
        }

        // POST: Employees/CreateServer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateServer(
       [Bind("Name,StartDate")] Server server)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _employeesRepository.createServer(server);
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
            return View(server);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _employeesRepository.getEmployee(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, DateTime EnrollmentDate, string Name, string DiscriminatorValue)
        {
            int employeeID = id;
            var employeeToUpdate = await _employeesRepository.getEmployee(employeeID);
            if (employeeToUpdate != null)
            {
                try
                {
                    // await _employeesRepository.updateEmployee(employeeID, employee);
                    return RedirectToAction("Index");
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            return View(employeeToUpdate);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _employeesRepository.getEmployee(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _employeesRepository.getEmployee(id);
            {
                if (employee == null)
                {
                    RedirectToAction("Index");
                }
                try
                {
                    await _employeesRepository.deleteEmployee(id);
                    return RedirectToAction("Index");
                }
                catch
                {
                    ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
                }
                return View(employee);

            }
        }
    }
}

