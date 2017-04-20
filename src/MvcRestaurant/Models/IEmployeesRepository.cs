using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRestaurant.Models
{
    public interface IEmployeesRepository
    {
        Task<IList<Employee>> getEmployees();
        Task createHost(Host host);
        Task createServer(Server server);
    }
}
