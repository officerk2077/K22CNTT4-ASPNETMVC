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
    public class Ntk_TACGIAController : Controller
    {
        private NguyenTrucKien_2210900033Entities db = new NguyenTrucKien_2210900033Entities();

        // GET: Ntk_TACGIA
        public ActionResult NtkIndex()
        {
            return View(db.Ntk_TACGIA.ToList());
        }

        // GET: Ntk_TACGIA/Details/5
        public ActionResult NtkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ntk_TACGIA ntk_TACGIA = db.Ntk_TACGIA.Find(id);
            if (ntk_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(ntk_TACGIA);
        }

        // GET: Ntk_TACGIA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ntk_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ntk_MaTG,Ntk_TenTG")] Ntk_TACGIA ntk_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Ntk_TACGIA.Add(ntk_TACGIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ntk_TACGIA);
        }

        // GET: Ntk_TACGIA/NtkEdit/5
        public ActionResult NtkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ntk_TACGIA ntk_TACGIA = db.Ntk_TACGIA.Find(id);
            if (ntk_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(ntk_TACGIA);
        }

        // POST: Ntk_TACGIA/NtkEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NtkEdit([Bind(Include = "Ntk_MaTG,Ntk_TenTG")] Ntk_TACGIA ntk_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ntk_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ntk_TACGIA);
        }

        // GET: Ntk_TACGIA/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ntk_TACGIA ntk_TACGIA = db.Ntk_TACGIA.Find(id);
            if (ntk_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(ntk_TACGIA);
        }

        // POST: Ntk_TACGIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ntk_TACGIA ntk_TACGIA = db.Ntk_TACGIA.Find(id);
            db.Ntk_TACGIA.Remove(ntk_TACGIA);
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
