using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleMVCApp.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Message"] = "Input your data:";
            ViewData["name"] = "";
            ViewData["mail"] = "";
            ViewData["tel"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Form()
        {
            ViewData["name"] = Request.Form["name"];
            ViewData["mail"] = Request.Form["mail"];
            ViewData["tel"] = Request.Form["tel"];
            ViewData["Message"] = Request.Form["name"]+ ","+Request.Form["mail"]+ "," + Request.Form["tel"];
            return View("Index");
        }
    }
}
