using NtkLesson06CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NtkLesson06CF.Controllers
{
    public class NtkCategoriesController : Controller
    {
        // GET: ntkCategories
        public ActionResult NtkIndex()
        {
            /*
             * Khởi tạo DbContext:
             * EF sẽ tìm thông tin kết nối trong file machinee.config của .NET Framework trên máy 
             * và sau đó tạo csdl
             */
            NtkBookStore ntkDb = new NtkBookStore();
            var ntkCategories = ntkDb.NtkCategories.ToList();
            return View(ntkCategories);
        }
    }
}