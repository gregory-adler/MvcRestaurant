using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRestaurant.Models
{
    public class Server : Employee
    {
       public double tips { get; set; }
    
       public override Employee MakeAInstance(string name, DateTime StartDate, string Discriminatorvalue)
        {
           Server newServer =  new Server { Name = "testServer", StartDate = DateTime.Parse("2010-09-01") };
            return newServer;
        }
    }
}