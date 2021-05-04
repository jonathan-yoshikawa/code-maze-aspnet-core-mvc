using AppMVC.Models;
using AppMVC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Repositories
{
    public class EmployeeManager : IDataRepository<Employee>
    {
        public void Add(Employee employee)
        {
            throw new NotImplementedException();
        }
        IEnumerable<Employee> IDataRepository<Employee>.GetAll()
        {
            return new List<Employee>() {
                new Employee(){ Id = 1, Name = "Jonathan", Age=34 },
                new Employee(){ Id = 2, Name = "Pedro", Age=24 },
                new Employee(){ Id = 3, Name = "João", Age=44 },
            };

        }
    }
}
