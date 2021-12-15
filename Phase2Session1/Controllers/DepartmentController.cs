using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer;
using Entities;
using DataAccessLayer.Repositories;

namespace APILayer.Controllers
{
    public class DepartmentController : BaseController<Department>
    {

        public DepartmentController(IBaseRepository<Department> repo) : base(repo)
        {
        }

    }
}
