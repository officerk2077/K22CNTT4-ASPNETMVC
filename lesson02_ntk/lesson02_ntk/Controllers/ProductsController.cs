using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson02_ntk.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products ~ http://localhost:44318/products
        public ActionResult Index()
        {
            ViewBag.name = "Trực Kiên - 2210900033";
            return View();
        }

        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }

        public string GetName()
        {
            return "Nguyễn Trực Kiên - 221090033";
        }

        public JsonResult ListName()
        {
            string[] names = { "Hùng", "Dũng", "Sang", "Trọng" };

            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}