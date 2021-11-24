using Entities;
using Microsoft.AspNetCore.Mvc;
using Phase2Session1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase2Session1.Controllers
{
    public class Employee_OldController : Controller
    {
        private List<Employee> Employees;

        public Employee_OldController()
        {
            this.Employees = new List<Employee>();
            this.Employees.Add(new Employee { ID = 1, Name = "Emp1", Dept = "IT" });
            this.Employees.Add(new Employee { ID = 2, Name = "Emp2", Dept = "HR" });
            this.Employees.Add(new Employee { ID = 3, Name = "Emp3", Dept = "Finance" });
            this.Employees.Add(new Employee { ID = 4, Name = "Emp4", Dept = "IT" });
        }

        public IActionResult Index()
        {
            EmployeeViewModel model = new EmployeeViewModel();
            model.Employees = Employees;
            return View(model);
        }
    }
}
