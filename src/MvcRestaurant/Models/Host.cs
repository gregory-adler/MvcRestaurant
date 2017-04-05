using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRestaurant.Models
{
    public class Host : Employee
    {
        public string greeting { get; set; }
        public override Employee MakeAInstance(string name, DateTime StartDate, string Discriminatorvalue)
        {
            Host newHost = new Host { Name = "testServer", StartDate = DateTime.Parse("2010-09-01") };
            return newHost;
        }
    }
}
