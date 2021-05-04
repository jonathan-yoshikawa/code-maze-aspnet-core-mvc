using AppMVC.Models;
using AppMVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDataRepository<Employee> _dataRepository;
        public EmployeeController(IDataRepository<Employee> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return View(employees);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _dataRepository.Add(employee);
            return RedirectToAction(actionName: nameof(Index));
        }
    }
}
