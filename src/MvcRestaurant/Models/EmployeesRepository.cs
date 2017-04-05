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
        public async Task<IList<Server>> getEmployees()
        {
            var employeesQuery = db.Servers
            .AsNoTracking();

            IList<Server> servers = new List<Server>();
            servers = await employeesQuery.ToListAsync();
            return servers;
        }
    }
}
