using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NtkLesson07Df.Models;

namespace NtkLesson07Df.Controllers
{
    public class NtkKhoasController : Controller
    {
        private NtkK22CNT4Lesson09DbEntities db = new NtkK22CNT4Lesson09DbEntities();

        // GET: NtkKhoas
        public ActionResult NtkIndex()
        {
            return View(db.ntkKhoas.ToList());
        }

        // GET: NtkKhoas/Details/5
        public ActionResult NtkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ntkKhoa ntkKhoa = db.ntkKhoas.Find(id);
            if (ntkKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ntkKhoa);
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
        public ActionResult NtkCreate([Bind(Include = "NtkMaKH,NtkTenKH,NtkTrangThai")] ntkKhoa ntkKhoa)
        {
            if (ModelState.IsValid)
            {
                db.ntkKhoas.Add(ntkKhoa);
                db.SaveChanges();
                return RedirectToAction("NtkIndex");
            }

            return View(ntkKhoa);
        }

        // GET: NtkKhoas/Edit/5
        public ActionResult NtkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ntkKhoa ntkKhoa = db.ntkKhoas.Find(id);
            if (ntkKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ntkKhoa);
        }

        // POST: NtkKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NtkEdit([Bind(Include = "NtkMaKH,NtkTenKH,NtkTrangThai")] ntkKhoa ntkKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ntkKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ntkKhoa);
        }

        // GET: NtkKhoas/Delete/5
        public ActionResult NtkDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ntkKhoa ntkKhoa = db.ntkKhoas.Find(id);
            if (ntkKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ntkKhoa);
        }

        // POST: NtkKhoas/Delete/5
        [HttpPost, ActionName("NtkDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NtkDeleteConfirmed(string id)
        {
            ntkKhoa ntkKhoa = db.ntkKhoas.Find(id);
            db.ntkKhoas.Remove(ntkKhoa);
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
