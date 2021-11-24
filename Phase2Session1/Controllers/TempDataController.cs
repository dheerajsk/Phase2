using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase2Session1.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult Index()
        {
            TempData["Student"] = "Jon Doe";
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }
    }
}
