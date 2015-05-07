using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperWebApp3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var c = new WebShared.Class1();
            ViewBag.Stuff = c.TestMethod();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}