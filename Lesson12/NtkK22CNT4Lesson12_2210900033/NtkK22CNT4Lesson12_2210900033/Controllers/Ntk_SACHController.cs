using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NtkK22CNT4Lesson12_2210900033.Models;

namespace NtkK22CNT4Lesson12_2210900033.Controllers
{
    public class Ntk_SACHController : Controller
    {
        private NguyenTrucKien_2210900033Entities db = new NguyenTrucKien_2210900033Entities();

        // GET: Ntk_SACH
        public ActionResult NtkIndex()
        {
            var ntk_SACH = db.Ntk_SACH.Include(n => n.Ntk_TACGIA);
            return View(ntk_SACH.ToList());
        }

        // GET: Ntk_SACH/Details/5
        public ActionResult NtkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ntk_SACH ntk_SACH = db.Ntk_SACH.Find(id);
            if (ntk_SACH == null)
            {
                return HttpNotFound();
            }
            return View(ntk_SACH);
        }

        // GET: Ntk_SACH/Create
        public ActionResult NtkCreate()
        {
            ViewBag.Ntk_MaTG = new SelectList(db.Ntk_TACGIA, "Ntk_MaTG", "Ntk_TenTG");
            return View();
        }

        // POST: Ntk_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NtkCreate([Bind(Include = "Ntk_MaSach,Ntk_TenSach,Ntk_SoTrang,Ntk_NamXB,Ntk_MaTG,Ntk_TrangThai")] Ntk_SACH ntk_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Ntk_SACH.Add(ntk_SACH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Ntk_MaTG = new SelectList(db.Ntk_TACGIA, "Ntk_MaTG", "Ntk_TenTG", ntk_SACH.Ntk_MaTG);
            return View(ntk_SACH);
        }

        // GET: Ntk_SACH/NtkEdit/5
        public ActionResult NtkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ntk_SACH ntk_SACH = db.Ntk_SACH.Find(id);
            if (ntk_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Ntk_MaTG = new SelectList(db.Ntk_TACGIA, "Ntk_MaTG", "Ntk_TenTG", ntk_SACH.Ntk_MaTG);
            return View(ntk_SACH);
        }

        // POST: Ntk_SACH/NtkEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NtkEdit([Bind(Include = "Ntk_MaSach,Ntk_TenSach,Ntk_SoTrang,Ntk_NamXB,Ntk_MaTG,Ntk_TrangThai")] Ntk_SACH ntk_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ntk_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NtkIndex");
            }
            ViewBag.Ntk_MaTG = new SelectList(db.Ntk_TACGIA, "Ntk_MaTG", "Ntk_TenTG", ntk_SACH.Ntk_MaTG);
            return View(ntk_SACH);
        }

        // GET: Ntk_SACH/Delete/5
        public ActionResult NtkDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ntk_SACH ntk_SACH = db.Ntk_SACH.Find(id);
            if (ntk_SACH == null)
            {
                return HttpNotFound();
            }
            return View(ntk_SACH);
        }

        // POST: Ntk_SACH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ntk_SACH ntk_SACH = db.Ntk_SACH.Find(id);
            db.Ntk_SACH.Remove(ntk_SACH);
            db.SaveChanges();
            return RedirectToAction("Index");
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
