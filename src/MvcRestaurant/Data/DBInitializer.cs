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
            var servers = new Server[]
          {
                new Server {Name = "test", StartDate = DateTime.Parse("2010-09-01")  },
          };
            foreach (Server s in servers)
            {
                context.Employees.Add(s);
            }
            context.SaveChanges();
        }
    }
}