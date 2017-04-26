using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcRestaurant.Data;
using Microsoft.EntityFrameworkCore;

namespace MvcRestaurant.Models
{
    public class EmployeesRepository : IEmployeesRepository
    {
        public ApplicationDbContext db;
        public EmployeesRepository(ApplicationDbContext database)
        {
            db = database;
        }
        public async Task<IList<Employee>> getEmployees()
        {
            var employeesQuery = db.Employees
            .AsNoTracking();

            IList<Employee> employees = new List<Employee>();
            employees = await employeesQuery.ToListAsync();
            return employees;
        }

        public async Task createHost(Host host)
        {
            db.Add(host);
            await db.SaveChangesAsync();

        }
        public async Task createServer(Server server)
        {
            db.Add(server);
            await db.SaveChangesAsync();
        }

        public async Task<Employee> getEmployee(int id)
        {
            var employee = await db.Employees.SingleOrDefaultAsync(e => e.ID == id);
            return employee;

        }
        
        public async Task updateEmployee(int id, Employee employee)
        {
            var toModify = db.Employees.SingleOrDefault(e => e.ID == id);
            db.Employees.Remove(toModify);
            db.Employees.Add(employee);
            await db.SaveChangesAsync();
        }
        public async Task deleteEmployee(int id)
        {
            var toDelete = db.Employees.SingleOrDefault(s => s.ID == id);
            if (toDelete == null)
            {
                return;
            }
            db.Employees.Remove(toDelete);
            await db.SaveChangesAsync();
        }

        public async Task<Employee> getEmployeeDetails(int id)
        {
            var employee = await db.Employees.SingleOrDefaultAsync(e => e.ID == id);
            return employee;
        }
    }
}
