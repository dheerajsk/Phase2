using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Phase2Session1.Controllers
{
    public class ActionResultsController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            ViewBag.Content = "This is a view returned by ViewResult.";
            return View();
        }

        public ContentResult Content()
        {
            return Content("This is content returned from ContentResult");
        }

        public RedirectResult Redirect()
        {
            return new RedirectResult("https://www.google.com");
        }

        public RedirectToRouteResult RedirectToRoute()
        {
            return new RedirectToRouteResult(new { Controller = "Home", action = "Privacy" });
        }

        [ActionName("Json")]
        public JsonResult GetJsonData()
        {
            string data = GetData();
            return Json(JObject.Parse(data));
        }

        [NonAction]
        public string GetData()
        {
            return System.IO.File.ReadAllText(@"./wwwroot/data.json");
        }
    }
}
