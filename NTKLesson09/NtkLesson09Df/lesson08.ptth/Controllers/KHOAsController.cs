using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lesson08.ntk.Models;

namespace lesson08.ntk.Controllers
{
    public class NtkKhoasController : Controller
    {
        private NtkK22CNT4Lesson09DbEntities db = new NtkK22CNT4Lesson09DbEntities();

        // GET: NtkKhoas
        public ActionResult Index()
        {
            //return View(db.NtkKhoas.ToList());
            return View(db.ntkNtkKhoas.ToList());
        }
        public ActionResult NtkIndex()
        {
            //return View(db.NtkKhoas.ToList());
            return View(db.NtkKhoas.ToList());
        }

        // GET: NtkKhoas/Details/5
        public ActionResult NtkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHOA kHOA = db.NtkKhoas.Find(id);
            if (kHOA == null)
            {
                return HttpNotFound();
            }
            return View(kHOA);
        }

        // GET: NtkKhoas/Create
        public ActionResult NtkCreate()
        {
            return View();
        }

        // POST: NtkKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NtkCreate([Bind(Include = "NtkMaKH,NtkTenKH")] KHOA kHOA)
        {
            if (ModelState.IsValid)
            {
                db.NtkKhoas.Add(kHOA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kHOA);
        }

        // GET: NtkKhoas/Edit/5
        public ActionResult NtkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHOA kHOA = db.NtkKhoas.Find(id);
            if (kHOA == null)
            {
                return HttpNotFound();
            }
            return View(kHOA);
        }

        // POST: NtkKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NtkEdit([Bind(Include = "NtkMaKH,NtkTenKH")] KHOA kHOA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kHOA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NtkIndex");
            }
            return View(kHOA);
        }

        // GET: NtkKhoas/Delete/5
        public ActionResult NtkDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHOA kHOA = db.NtkKhoas.Find(id);
            if (kHOA == null)
            {
                return HttpNotFound();
            }
            return View(kHOA);
        }

        // POST: NtkKhoas/Delete/5
        [HttpPost, ActionName("NtkDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KHOA kHOA = db.NtkKhoas.Find(id);
            db.NtkKhoas.Remove(kHOA);
            db.SaveChanges();
            return RedirectToAction("NtkIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
