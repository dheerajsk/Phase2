using DataAccessLayer.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : BaseController<Employee>
    {
        public EmployeeController(IBaseRepository<Employee> repo) : base(repo)
        {
        }

        [HttpGet("GetXML")]
        public IActionResult GetXML()
        {
            var result = "<result>test</result>";
            return new ContentResult
            {
                Content = result,
                ContentType = "application/xml"
            };

        }
    }
}
