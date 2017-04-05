using MvcRestaurant.Models;
using System;
using System.Linq;
using MvcRestaurant.Data;

namespace MvcRestaurant.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }
            var employees = new Employee[]
          {
                new Server {Name = "testServer", StartDate = DateTime.Parse("2010-09-01")  },
                new Host {Name = "testHost", StartDate = DateTime.Parse("2010-09-01")  },
          };
            foreach (Employee s in employees)
            {
                context.Employees.Add(s);
            }
            context.SaveChanges();
        }
    }
}