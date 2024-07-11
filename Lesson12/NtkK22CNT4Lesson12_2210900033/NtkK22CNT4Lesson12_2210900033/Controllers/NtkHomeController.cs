using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NtkK22CNT4Lesson12_2210900033.Controllers
{
    public class NtkHomeController : Controller
    {
        public ActionResult NtkIndex()
        {
            return View();
        }

        public ActionResult NtkAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NtkContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}