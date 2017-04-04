using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRestaurant.Models
{
    public class Server
    {
        public int ServerId { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string type { get; set; }
    }
}