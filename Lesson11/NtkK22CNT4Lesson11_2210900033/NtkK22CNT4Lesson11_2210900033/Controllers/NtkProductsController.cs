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
    public class NtkProductsController : Controller
    {
        private NtkK22CNT4Lesson11DbEntities db = new NtkK22CNT4Lesson11DbEntities();

        // GET: NtkProducts
        public ActionResult NtkIndex()
        {
            var ntkProducts = db.NtkProducts.Include(n => n.NtkCategory);
            return View(ntkProducts.ToList());
        }

        // GET: NtkProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtkProduct ntkProduct = db.NtkProducts.Find(id);
            if (ntkProduct == null)
            {
                return HttpNotFound();
            }
            return View(ntkProduct);
        }

        // GET: NtkProducts/Create
        public ActionResult Create()
        {
            ViewBag.NtkCateId = new SelectList(db.NtkCategories, "NtkID", "NtkCateName");
            return View();
        }

        // POST: NtkProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NtkId2210900033,NtkProName,NtkQty,NtkPrice,NtkCateId,NtkActive")] NtkProduct ntkProduct)
        {
            if (ModelState.IsValid)
            {
                db.NtkProducts.Add(ntkProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NtkCateId = new SelectList(db.NtkCategories, "NtkID", "NtkCateName", ntkProduct.NtkCateId);
            return View(ntkProduct);
        }

        // GET: NtkProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtkProduct ntkProduct = db.NtkProducts.Find(id);
            if (ntkProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.NtkCateId = new SelectList(db.NtkCategories, "NtkID", "NtkCateName", ntkProduct.NtkCateId);
            return View(ntkProduct);
        }

        // POST: NtkProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NtkId2210900033,NtkProName,NtkQty,NtkPrice,NtkCateId,NtkActive")] NtkProduct ntkProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ntkProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NtkCateId = new SelectList(db.NtkCategories, "NtkID", "NtkCateName", ntkProduct.NtkCateId);
            return View(ntkProduct);
        }

        // GET: NtkProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtkProduct ntkProduct = db.NtkProducts.Find(id);
            if (ntkProduct == null)
            {
                return HttpNotFound();
            }
            return View(ntkProduct);
        }

        // POST: NtkProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NtkProduct ntkProduct = db.NtkProducts.Find(id);
            db.NtkProducts.Remove(ntkProduct);
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
