using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NtkK22CNT4Lesson11_2210900033.Models;

namespace NtkK22CNT4Lesson11_2210900033.Controllers
{
    public class NtkCategoriescController : Controller
    {
        private NtkK22CNT4Lesson11DbEntities db = new NtkK22CNT4Lesson11DbEntities();

        // GET: NtkCategories
        public ActionResult NtkIndex()
        {
            return View(db.NtkCategories.ToList());
        }

        // GET: NtkCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtkCategory ntkCategory = db.NtkCategories.Find(id);
            if (ntkCategory == null)
            {
                return HttpNotFound();
            }
            return View(ntkCategory);
        }

        // GET: NtkCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NtkCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NtkID,NtkCateName,NtkStatus")] NtkCategory ntkCategory)
        {
            if (ModelState.IsValid)
            {
                db.NtkCategories.Add(ntkCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ntkCategory);
        }

        // GET: NtkCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtkCategory ntkCategory = db.NtkCategories.Find(id);
            if (ntkCategory == null)
            {
                return HttpNotFound();
            }
            return View(ntkCategory);
        }

        // POST: NtkCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NtkID,NtkCateName,NtkStatus")] NtkCategory ntkCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ntkCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ntkCategory);
        }

        // GET: NtkCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtkCategory ntkCategory = db.NtkCategories.Find(id);
            if (ntkCategory == null)
            {
                return HttpNotFound();
            }
            return View(ntkCategory);
        }

        // POST: NtkCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NtkCategory ntkCategory = db.NtkCategories.Find(id);
            db.NtkCategories.Remove(ntkCategory);
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
