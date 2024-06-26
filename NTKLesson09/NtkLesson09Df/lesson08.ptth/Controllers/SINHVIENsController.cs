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
    public class NtkSinhViensController : Controller
    {
        private NtkK22CNT4Lesson09DbEntities db = new NtkK22CNT4Lesson09DbEntities();

        // GET: NtkSinhViens
        public ActionResult NtkIndex()
        {
            return View(db.NtkSinhViens.ToList());
        }

        // GET: NtkSinhViens/Details/5
        public ActionResult NtkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SINHVIEN sINHVIEN = db.NtkSinhViens.Find(id);
            if (sINHVIEN == null)
            {
                return HttpNotFound();
            }
            return View(sINHVIEN);
        }

        // GET: NtkSinhViens/Create
        public ActionResult NtkCreate()
        {
            return View();
        }

        // POST: NtkSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NtkCreate([Bind(Include = "NtkMaSV,NtkHoSV,NtkTenSV,NtkPhai,NtkNgaySinh,NtkNoiSinh,NtkMaKH,NtkHocBong,NtkDiemTrungBinh")] SINHVIEN sINHVIEN)
        {
            if (ModelState.IsValid)
            {
                db.NtkSinhViens.Add(sINHVIEN);
                db.SaveChanges();
                return RedirectToAction("NtkIndex");
            }

            return View(sINHVIEN);
        }

        // GET: NtkSinhViens/Edit/5
        public ActionResult NtkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SINHVIEN sINHVIEN = db.NtkSinhViens.Find(id);
            if (sINHVIEN == null)
            {
                return HttpNotFound();
            }
            return View(sINHVIEN);
        }

        // POST: NtkSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NtkEdit([Bind(Include = "NtkMaSV,NtkHoSV,NtkTenSV,NtkPhai,NtkNgaySinh,NtkNoiSinh,NtkMaKH,NtkHocBong,NtkDiemTrungBinh")] SINHVIEN sINHVIEN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sINHVIEN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NtkIndex");
            }
            return View(sINHVIEN);
        }

        // GET: NtkSinhViens/Delete/5
        public ActionResult NtkDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SINHVIEN sINHVIEN = db.NtkSinhViens.Find(id);
            if (sINHVIEN == null)
            {
                return HttpNotFound();
            }
            return View(sINHVIEN);
        }

        // POST: NtkSinhViens/Delete/5
        [HttpPost, ActionName("NtkDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SINHVIEN sINHVIEN = db.NtkSinhViens.Find(id);
            db.NtkSinhViens.Remove(sINHVIEN);
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
