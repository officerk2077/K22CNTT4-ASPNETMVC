using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace lesson03_ntk.Controllers
{
    public class NTKStudentController : Controller
    {
        // GET: NTKStudent
        public ActionResult Index()
        {
            // du lieu tu Viewdata
            ViewData["msg"] = "View Data - Nguyen Truc Kien";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult StudentList()
        {
            // Su dung ViewBag
            // Luu tru gia tri don
            ViewBag.titleName = "Danh sách học viên - Nguyễn Trực Kiên";

            // GIa tri la 1 tap hop 
            string[] names = { "Trần Tiến", "Tạ Hồng", "Diễm Hương", "Vương Định" };
            ViewBag.list = names;

            // Gia tri la 1 doi tuong
            var obj = new
            {
                ID= 100,
                Name= "Kien Kien",
                Age= 45
            };
            ViewBag.student = obj;
            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}