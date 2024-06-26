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
    public class NtkNtkKetquasController : Controller
    {
        private NtkK22CNT4Lesson09DbEntities db = new NtkK22CNT4Lesson09DbEntities();

        // GET: NtkNtkKetquas
        public ActionResult NtkIndex()
        {
            var ntkNtkKetquas = db.ntkNtkNtkKetquas.Include(k => k.MONHOC).Include(k => k.SINHVIEN);
            return View(ntkNtkKetqua.ToList());
        }

        // GET: NtkNtkKetquas/Details/5
        public ActionResult NtkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTKKETQUA ntkKetqua = db.NtkNtkKetquas.Find(id);
            if (ntkKetqua == null)
            {
                return HttpNotFound();
            }
            return View(ntkKetqua);
        }

        // GET: NtkNtkKetquas/Create
        public ActionResult NtkCreate()
        {
            ViewBag.NtkMaMH = new SelectList(db.ntkNtkMonHocs, "NtkMaMH", "NtkTenMH");
            ViewBag.NtkMaSV = new SelectList(db.ntkNtkSinhViens, "NtkMaSV", "NtkHoSV");
            return View();
        }

        // POST: NtkNtkKetquas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NtkCreate([Bind(Include = "NtkMaSV,NtkMaMH,NtkDiem")] ntkNtkKetqua ntkNtkKetqua)
        {
            if (ModelState.IsValid)
            {
                db.NtkNtkKetquas.Add(ntkKetqua);
                db.SaveChanges();
                return RedirectToAction("NtkIndex");
            }

            ViewBag.NtkMaMH = new SelectList(db.NtkMonHocs, "NtkMaMH", "NtkTenMH", ntkNtkKetqua.NtkMaMH);
            ViewBag.NtkMaSV = new SelectList(db.NtkSinhViens, "NtkMaSV", "NtkHoSV", ntkKetqua.NtkMaSV);
            return View(ntkKetqua);
        }

        // GET: NtkNtkKetquas/Edit/5
        public ActionResult NtkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTKKETQUA ntkKetqua = db.NtkNtkKetquas.Find(id);
            if (ntkKetqua == null)
            {
                return HttpNotFound();
            }
            ViewBag.NtkMaMH = new SelectList(db.NtkMonHocs, "NtkMaMH", "NtkTenMH", ntkKetqua.NtkMaMH);
            ViewBag.NtkMaSV = new SelectList(db.NtkSinhViens, "NtkMaSV", "NtkHoSV", ntkKetqua.NtkMaSV);
            return View(ntkKetqua);
        }

        // POST: NtkNtkKetquas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NtkMaSV,NtkMaMH,NtkDiem")] NTKKETQUA ntkKetqua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ntkKetqua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NtkMaMH = new SelectList(db.NtkMonHocs, "NtkMaMH", "NtkTenMH", ntkKetqua.NtkMaMH);
            ViewBag.NtkMaSV = new SelectList(db.NtkSinhViens, "NtkMaSV", "NtkHoSV", ntkKetqua.NtkMaSV);
            return View(ntkKetqua);
        }

        // GET: NtkNtkKetquas/Delete/5
        public ActionResult NtkDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTKKETQUA ntkKetqua = db.NtkNtkKetquas.Find(id);
            if (ntkKetqua == null)
            {
                return HttpNotFound();
            }
            return View(ntkKetqua);
        }

        // POST: NtkNtkKetquas/Delete/5
        [HttpPost, ActionName("NtkDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NTKKETQUA ntkKetqua = db.NtkNtkKetquas.Find(id);
            db.NtkNtkKetquas.Remove(ntkKetqua);
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
