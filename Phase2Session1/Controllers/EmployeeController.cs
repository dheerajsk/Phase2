using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILayer.Controllers;
using DataAccessLayer.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Phase2Session1.Controllers
{
    public class EmployeeController : BaseController<Employee>
    {
        public EmployeeController(IBaseRepository<Employee> repo): base(repo)
        {
        }
    }
}
