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
    public class AgencyOfficesController : Controller
    {
        private EntertainerManagementEntities db = new EntertainerManagementEntities();

        // GET: AgencyOffices
        public ActionResult Index()
        {
            var agencyOffices = db.AgencyOffices.Include(a => a.Address).Include(a => a.Agency).Include(a => a.OfficeContactInformation);
            return View(agencyOffices.ToList());
        }

        // GET: AgencyOffices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgencyOffice agencyOffice = db.AgencyOffices.Find(id);
            if (agencyOffice == null)
            {
                return HttpNotFound();
            }
            return View(agencyOffice);
        }

        // GET: AgencyOffices/Create
        public ActionResult Create()
        {
            ViewBag.FK_addressID = new SelectList(db.Addresses, "Address_ID", "Address_address");
            ViewBag.FK_agencyID = new SelectList(db.Agencies, "Agency_ID", "Agency_name");
            ViewBag.FK_ContactInfoID = new SelectList(db.OfficeContactInformations, "ContactInfo_ID", "ContactInfo_phoneNo");
            return View();
        }

        // POST: AgencyOffices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FK_agencyID,FK_addressID,FK_ContactInfoID")] AgencyOffice agencyOffice)
        {
            if (ModelState.IsValid)
            {
                db.AgencyOffices.Add(agencyOffice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FK_addressID = new SelectList(db.Addresses, "Address_ID", "Address_address", agencyOffice.FK_addressID);
            ViewBag.FK_agencyID = new SelectList(db.Agencies, "Agency_ID", "Agency_name", agencyOffice.FK_agencyID);
            ViewBag.FK_ContactInfoID = new SelectList(db.OfficeContactInformations, "ContactInfo_ID", "ContactInfo_phoneNo", agencyOffice.FK_ContactInfoID);
            return View(agencyOffice);
        }

        // GET: AgencyOffices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgencyOffice agencyOffice = db.AgencyOffices.Find(id);
            if (agencyOffice == null)
            {
                return HttpNotFound();
            }
            ViewBag.FK_addressID = new SelectList(db.Addresses, "Address_ID", "Address_address", agencyOffice.FK_addressID);
            ViewBag.FK_agencyID = new SelectList(db.Agencies, "Agency_ID", "Agency_name", agencyOffice.FK_agencyID);
            ViewBag.FK_ContactInfoID = new SelectList(db.OfficeContactInformations, "ContactInfo_ID", "ContactInfo_phoneNo", agencyOffice.FK_ContactInfoID);
            return View(agencyOffice);
        }

        // POST: AgencyOffices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FK_agencyID,FK_addressID,FK_ContactInfoID")] AgencyOffice agencyOffice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agencyOffice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FK_addressID = new SelectList(db.Addresses, "Address_ID", "Address_address", agencyOffice.FK_addressID);
            ViewBag.FK_agencyID = new SelectList(db.Agencies, "Agency_ID", "Agency_name", agencyOffice.FK_agencyID);
            ViewBag.FK_ContactInfoID = new SelectList(db.OfficeContactInformations, "ContactInfo_ID", "ContactInfo_phoneNo", agencyOffice.FK_ContactInfoID);
            return View(agencyOffice);
        }

        // GET: AgencyOffices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgencyOffice agencyOffice = db.AgencyOffices.Find(id);
            if (agencyOffice == null)
            {
                return HttpNotFound();
            }
            return View(agencyOffice);
        }

        // POST: AgencyOffices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AgencyOffice agencyOffice = db.AgencyOffices.Find(id);
            db.AgencyOffices.Remove(agencyOffice);
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
