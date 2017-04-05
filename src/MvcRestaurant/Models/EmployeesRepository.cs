using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcRestaurant.Data;

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
            return null;
        }
    }
}
