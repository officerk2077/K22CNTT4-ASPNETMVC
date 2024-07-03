using NtkK22CNT4Lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NtkK22CNT4Lesson10.Controllers
{
    public class NtkHomeController : Controller
    {
        public ActionResult NtkIndex()
        {
            //Kiểm tra dữ liệu trong Session
            if (Session["NtkAccount"] != null)
            {
                var ntkAccount = Session["NtkAccount"] as NtkAccount;
                ViewBag.FullName = ntkAccount.NtkFullName;
            }    
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