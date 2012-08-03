using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScarlettsLog.Mobile.Models;

namespace ScarlettsLog.Mobile.Controllers
{
    public class LogEntriesController : RavenController
    {
        //
        // GET: /LogEntries/

        public ViewResult Index()
        {
            return View(RavenSession.Query<LogEntry>().ToArray());
        }

        //
        // GET: /LogEntries/Details/5

        public ViewResult Details(int id)
        {
            LogEntry logentry = RavenSession.Load<LogEntry>(id);
            return View(logentry);
        }

        //
        // GET: /LogEntries/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /LogEntries/Create

        [HttpPost]
        public ActionResult Create(LogEntry logentry)
        {
            if (!ModelState.IsValid)
            {
                return View(logentry);
            }
            RavenSession.Store(logentry);
            return RedirectToAction("Index");            
        }

        //
        // GET: /LogEntries/Edit/5

        public ActionResult Edit(int id)
        {
            LogEntry logentry = RavenSession.Load<LogEntry>(id); 
            return View(logentry);
        }

        //
        // POST: /LogEntries/Edit/5

        [HttpPost]
        public ActionResult Edit(LogEntry logentry)
        {
            if (!ModelState.IsValid)
            {
                return View(logentry); 
            }
            return RedirectToAction("Index");
        }

        //
        // GET: /LogEntries/Delete/5

        public ActionResult Delete(int id)
        {
            LogEntry logentry = RavenSession.Load<LogEntry>(id);
            return View(logentry);
        }

        //
        // POST: /LogEntries/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            LogEntry logentry = RavenSession.Load<LogEntry>(id);
            RavenSession.Delete<LogEntry>(logentry);
            return RedirectToAction("Index");
        }
    }
}