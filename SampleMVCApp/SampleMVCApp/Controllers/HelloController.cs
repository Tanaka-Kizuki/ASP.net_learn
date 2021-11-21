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
        //public List<string> list;

        //public HelloController()
        //{
        //    list = new List<string>();
        //    list.Add("Japan");
        //    list.Add("USA");
        //    list.Add("UK");

        //}

        [Route("Hello/{id?}/{name?}")]
        public IActionResult Index(int id,string name)
        {
            ViewData["message"] = "id=" + id + "name=" + name;
            //ViewData["list"] = "";
            //ViewData["listdata"] = list;
            return View();
        }

        //[HttpPost]
        //public IActionResult Form()
        //{
        //    ViewData["message"] = "" + Request.Form["list"] + '"' + "selected";
        //    ViewData["list"] = Request.Form["list"];
        //    ViewData["listdata"] = list;
        //    return View("Index");
        //}
    }
}
