using Ntk_Lesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;

namespace Ntk_Lesson05.Controllers
{
    public class NtkCustomerController : Controller
    {
        // GET: NtkCustomer
        public ActionResult Index()
        {
            return View();
        }

        // Action: NtkCustomerDetail
        public ActionResult NtkCustomerDetail()
        {
            // Tạo đối tượng dữ liệu
            var customer = new NtkCustomer()
            {
                CustomerId = 1,
                FirstName = "Nguyễn Trực",
                LastName = "Kiên",
                Address = "Phúc Yên",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View(); 
        }

        // GET: NtkListCustomer
        public ActionResult NtkListCustomer() 
        {
            var list = new List<NtkCustomer>();
            {
                new NtkCustomer()
                {
                    CustomerId = 1,
                    FirstName = "Nguyễn Trực",
                    LastName = "Kiên",
                    Address = "Phúc Yên",
                    YearOfBirth = 2004
                };
                new NtkCustomer()
                {
                    CustomerId = 2,
                    FirstName = "Dương Thị Hà",
                    LastName = "My 1",
                    Address = "K22CNT4",
                    YearOfBirth = 2004
                };
                new NtkCustomer()
                {
                    CustomerId = 2,
                    FirstName = "Dương Thị Hà",
                    LastName = "My 2",
                    Address = "K22CNT4",
                    YearOfBirth = 2004
                };
            };
            ViewBag.list = list; // Đưa dữ liệu ra view bằng đối tượng ViewBag
            return View();
        }
    }
}