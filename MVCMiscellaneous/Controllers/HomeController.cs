using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMiscellaneous.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string choise = "o")
        {
            if (choise.Equals("a"))
                ViewBag.ActionName = "register";
            else
                ViewBag.ActionName = "login";
            ViewBag.Test = "elisha";
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

        [NonAction]
        public void Shalom()
        {
            string greeting = "shalom haver!";
        }

        public string Hello()
        {
            string greeting = "shalom haver!";
            return greeting;
        }

        public ActionResult Countries (List<string> countryNames)
        {
            return View(countryNames);
        }
    }
}