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
    public class NtkMonHocsController : Controller
    {
        private NtkK22CNT4Lesson09DbEntities db = new NtkK22CNT4Lesson09DbEntities();

        // GET: NtkMonHocs
        public ActionResult NtkIndex()
        {
            return View(db.NtkMonHocs.ToList());
        }

        // GET: NtkMonHocs/Details/5
        public ActionResult NtkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONHOC mONHOC = db.NtkMonHocs.Find(id);
            if (mONHOC == null)
            {
                return HttpNotFound();
            }
            return View(mONHOC);
        }

        // GET: NtkMonHocs/Create
        public ActionResult NtkCreate()
        {
            return View();
        }

        // POST: NtkMonHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NtkMaMH,NtkTenMH,NtkSoTiet")] MONHOC mONHOC)
        {
            if (ModelState.IsValid)
            {
                db.NtkMonHocs.Add(mONHOC);
                db.SaveChanges();
                return RedirectToAction("NtkIndex");
            }

            return View(mONHOC);
        }

        // GET: NtkMonHocs/Edit/5
        public ActionResult NtkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONHOC mONHOC = db.NtkMonHocs.Find(id);
            if (mONHOC == null)
            {
                return HttpNotFound();
            }
            return View(mONHOC);
        }

        // POST: NtkMonHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NtkEdit([Bind(Include = "NtkMaMH,NtkTenMH,NtkSoTiet")] MONHOC mONHOC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mONHOC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NtkIndex");
            }
            return View(mONHOC);
        }

        // GET: NtkMonHocs/Delete/5
        public ActionResult NtkDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONHOC mONHOC = db.NtkMonHocs.Find(id);
            if (mONHOC == null)
            {
                return HttpNotFound();
            }
            return View(mONHOC);
        }

        // POST: NtkMonHocs/Delete/5
        [HttpPost, ActionName("NtkDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MONHOC mONHOC = db.NtkMonHocs.Find(id);
            db.NtkMonHocs.Remove(mONHOC);
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
