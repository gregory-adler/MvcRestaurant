using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcRestaurant.Models
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string DiscriminatorValue
        {
            get
            {
                return this.GetType().Name;
            }
        }
        public List<String> Types
        {
            get
            {
                List<String> employeeTypes = new List<String>();
                employeeTypes.Add("Server");
                employeeTypes.Add("Host");
                return employeeTypes;
            }
        }
    }
}
