using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NtkK22CNT4Lesson10.Models;

namespace NtkK22CNT4Lesson10.Controllers
{
    public class NtkAccountsController : Controller
    {
        private NtkK22CNT4Lesson10DbEntities2 db = new NtkK22CNT4Lesson10DbEntities2();

        // GET: NtkAccounts
        public ActionResult Index()
        {
            return View(db.NtkAccounts.ToList());
        }

        // GET: NtkAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtkAccount ntkAccount = db.NtkAccounts.Find(id);
            if (ntkAccount == null)
            {
                return HttpNotFound();
            }
            return View(ntkAccount);
        }

        // GET: NtkAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NtkAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NtkID,NtkUserName,NtkPassword,NtkFullName,NtkEmail,NtkPhone,NtkActive")] NtkAccount ntkAccount)
        {
            if (ModelState.IsValid)
            {
                db.NtkAccounts.Add(ntkAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ntkAccount);
        }

        // GET: NtkAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtkAccount ntkAccount = db.NtkAccounts.Find(id);
            if (ntkAccount == null)
            {
                return HttpNotFound();
            }
            return View(ntkAccount);
        }

        // POST: NtkAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NtkID,NtkUserName,NtkPassword,NtkFullName,NtkEmail,NtkPhone,NtkActive")] NtkAccount ntkAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ntkAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ntkAccount);
        }

        // GET: NtkAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NtkAccount ntkAccount = db.NtkAccounts.Find(id);
            if (ntkAccount == null)
            {
                return HttpNotFound();
            }
            return View(ntkAccount);
        }

        // POST: NtkAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NtkAccount ntkAccount = db.NtkAccounts.Find(id);
            db.NtkAccounts.Remove(ntkAccount);
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

        //login
        public ActionResult NtkLogin()
        {
            var ntkModel = new NtkAccount();
            return View(ntkModel); 
        }
        [HttpPost]
        public ActionResult NtkLogin(NtkAccount ntkAccount)
        {
            var ntkCheck = db.NtkAccounts.Where(x => x.NtkUserName.Equals(ntkAccount.NtkUserName) && x.NtkPassword.Equals(ntkAccount.NtkPassword)).FirstOrDefault();
            if (ntkCheck != null)
            {
                Session["NtkAccount"] = ntkCheck;
                return Redirect("/");
            }
            return View(ntkAccount);
        }
    }
}
