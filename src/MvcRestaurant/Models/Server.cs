using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRestaurant.Models
{
    public class Server
    {

        public int ServerId { get; set; }
        private string name { get; set; }
        private int age { get; set; }
        private string type { get; set; }
    }
}