using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntertainerManagementSite.Models;

namespace EntertainerManagementSite.Controllers
{
    public class agentEntertainersController : Controller
    {
        private EntertainerManagementEntities db = new EntertainerManagementEntities();

        // GET: agentEntertainers
        public ActionResult Index()
        {
            return View(db.agentEntertainers.ToList());
        }

        // GET: agentEntertainers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            agentEntertainer agentEntertainer = db.agentEntertainers.Find(id);
            if (agentEntertainer == null)
            {
                return HttpNotFound();
            }
            return View(agentEntertainer);
        }

        // GET: agentEntertainers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: agentEntertainers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Agent_fName,Agent_lName,Entertainer_name")] agentEntertainer agentEntertainer)
        {
            if (ModelState.IsValid)
            {
                db.agentEntertainers.Add(agentEntertainer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agentEntertainer);
        }

        // GET: agentEntertainers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            agentEntertainer agentEntertainer = db.agentEntertainers.Find(id);
            if (agentEntertainer == null)
            {
                return HttpNotFound();
            }
            return View(agentEntertainer);
        }

        // POST: agentEntertainers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Agent_fName,Agent_lName,Entertainer_name")] agentEntertainer agentEntertainer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agentEntertainer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agentEntertainer);
        }

        // GET: agentEntertainers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            agentEntertainer agentEntertainer = db.agentEntertainers.Find(id);
            if (agentEntertainer == null)
            {
                return HttpNotFound();
            }
            return View(agentEntertainer);
        }

        // POST: agentEntertainers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            agentEntertainer agentEntertainer = db.agentEntertainers.Find(id);
            db.agentEntertainers.Remove(agentEntertainer);
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
