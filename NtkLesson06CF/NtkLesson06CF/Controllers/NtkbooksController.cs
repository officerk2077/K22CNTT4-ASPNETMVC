using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NtkLesson06CF.Models;

namespace NtkLesson06CF.Controllers
{
    public class NtkbooksController : Controller
    {
        private NtkBookStore db = new NtkBookStore();

        // GET: Ntkbooks
        public ActionResult Index()
        {
            return View(db.Ntkbooks.ToList());
        }

        // GET: Ntkbooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ntkbook ntkbook = db.Ntkbooks.Find(id);
            if (ntkbook == null)
            {
                return HttpNotFound();
            }
            return View(ntkbook);
        }

        // GET: Ntkbooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ntkbooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NtkId,NtkTitle,NtkAuthor,NtkYear,NtkPublisher,NtkPicture,NtkCategoryId")] Ntkbook ntkbook)
        {
            if (ModelState.IsValid)
            {
                db.Ntkbooks.Add(ntkbook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ntkbook);
        }

        // GET: Ntkbooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ntkbook ntkbook = db.Ntkbooks.Find(id);
            if (ntkbook == null)
            {
                return HttpNotFound();
            }
            return View(ntkbook);
        }

        // POST: Ntkbooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NtkId,NtkTitle,NtkAuthor,NtkYear,NtkPublisher,NtkPicture,NtkCategoryId")] Ntkbook ntkbook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ntkbook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ntkbook);
        }

        // GET: Ntkbooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ntkbook ntkbook = db.Ntkbooks.Find(id);
            if (ntkbook == null)
            {
                return HttpNotFound();
            }
            return View(ntkbook);
        }

        // POST: Ntkbooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ntkbook ntkbook = db.Ntkbooks.Find(id);
            db.Ntkbooks.Remove(ntkbook);
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
