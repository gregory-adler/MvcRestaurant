using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRestaurant.Models
{
    public class Server : Employee
    {
       public double tips { get; set; }
    }
}