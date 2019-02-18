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
    public class AgentsController : Controller
    {
        private EntertainerManagementEntities db = new EntertainerManagementEntities();

        // GET: Agents
        public ActionResult Index()
        {
            var agents = db.Agents.Include(a => a.AgencyOffice).Include(a => a.AgentContactInformation);
            return View(agents.ToList());
        }

        // GET: Agents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agent agent = db.Agents.Find(id);
            var fullname = agent.Agent_fName + " " + agent.Agent_lName;
            var agentWithEntertainers = db.GetAgentWithEntertainersByName(fullname).FirstOrDefault(); ;
            if (agentWithEntertainers == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            return View(agentWithEntertainers);
        }

        // GET: Agents/Create
        public ActionResult Create()
        {
            ViewBag.FK_agencyOfficeID = new SelectList(db.AgencyOffices, "FK_addressID", "FK_addressID");
            ViewBag.Agent_ID = new SelectList(db.AgentContactInformations, "FK_AgentID", "ContactInfo_phoneNo");
            return View();
        }

        // POST: Agents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Agent_ID,Agent_fName,Agent_lName,Agent_salary,Agent_hiringDate,FK_agencyOfficeID")] Agent agent)
        {
            if (ModelState.IsValid)
            {
                db.Agents.Add(agent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FK_agencyOfficeID = new SelectList(db.AgencyOffices, "FK_addressID", "FK_addressID", agent.FK_agencyOfficeID);
            ViewBag.Agent_ID = new SelectList(db.AgentContactInformations, "FK_AgentID", "ContactInfo_phoneNo", agent.Agent_ID);
            return View(agent);
        }

        // GET: Agents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agent agent = db.Agents.Find(id);
            if (agent == null)
            {
                return HttpNotFound();
            }
            ViewBag.FK_agencyOfficeID = new SelectList(db.AgencyOffices, "FK_addressID", "FK_addressID", agent.FK_agencyOfficeID);
            ViewBag.Agent_ID = new SelectList(db.AgentContactInformations, "FK_AgentID", "ContactInfo_phoneNo", agent.Agent_ID);
            return View(agent);
        }

        // POST: Agents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Agent_ID,Agent_fName,Agent_lName,Agent_salary,Agent_hiringDate,FK_agencyOfficeID")] Agent agent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FK_agencyOfficeID = new SelectList(db.AgencyOffices, "FK_addressID", "FK_addressID", agent.FK_agencyOfficeID);
            ViewBag.Agent_ID = new SelectList(db.AgentContactInformations, "FK_AgentID", "ContactInfo_phoneNo", agent.Agent_ID);
            return View(agent);
        }

        // GET: Agents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agent agent = db.Agents.Find(id);
            if (agent == null)
            {
                return HttpNotFound();
            }
            return View(agent);
        }

        // POST: Agents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Agent agent = db.Agents.Find(id);
            db.Agents.Remove(agent);
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
