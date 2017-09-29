using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KYHBPA_TeamA.Models;
using System.Linq;

namespace KYHBPA_TeamA.Controllers
{
    public class MembershipController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Membership
        public ActionResult Index()
        {
            return View(db.Membership.ToList());
        }

        // GET: Membership/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membership membership = db.Membership.Find(id);
            if (membership == null)
            {
                return HttpNotFound();
            }
            return View(membership);
        }

        // GET: Membership/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Membership/Create
        [HttpPost]
        public ActionResult Create(Membership membership)
        {
            if(ModelState.IsValid)
            {
                db.Membership.Add(membership);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
                return View(membership);
        }

        // GET: Membership/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membership membership = db.Membership.Find(id);
            if (membership == null)
            {
                return HttpNotFound();
            }
            return View(membership);
        }

        // POST: Membership/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, Membership membership)
        {
            if (ModelState.IsValid)
            {
                db.Entry(membership).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
                return View(membership);
        }

        // GET: Membership/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membership membership = db.Membership.Find(id);
            if (membership == null)
            {
                return HttpNotFound();
            }
            return View(membership);
        }

        // POST: Membership/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteYes(int? id)
        {
                Membership membership = db.Membership.Find(id);
                db.Membership.Remove(membership);
                db.SaveChanges();
                return RedirectToAction("Index");
        }
    }
}
