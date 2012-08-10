using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiabetesRavenKendo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Scarlett's Log";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
