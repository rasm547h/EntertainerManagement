using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirebaseNet.Database;
using EntertainerManagementModels;
using JsonServiceSerializers;
using System.Net;

namespace EntertainerManagementSite.Controllers
{
    public class EventsController : Controller
    {
        FirebaseDB db = new FirebaseDB("https://entertainermanagement-1603b.firebaseio.com/").Node("Event");
        // GET: Events
        public ActionResult Index()
        {
            var indexRet = db.Get();
            if (indexRet.Success)
            {
                if (!string.IsNullOrEmpty(indexRet.JSONContent))
                {
                    var obj = new JsonService<List<Event>>().Deserialize(indexRet.JSONContent);
                    return obj != null ? View(obj) : View(new List<Event>());
                }
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(new List<Event>());
        }

        // GET: Events/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "EventID,EventName,EventLocation")]Event newEvent)
        {
            var result = db.Put(new JsonService<Event>().Serializer(newEvent));
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View(newEvent);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Events/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Events/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Events/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
