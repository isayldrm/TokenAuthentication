using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServisInterface.Controllers
{
    //şifremeleme işlemi yapıp herkese erişimi engelleniyor.
    [Authorize] 
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using(EmployeeDbEntities entities = new EmployeeDbEntities())
            {
                return entities.Employees.ToList();
            }
        }
    }
}
