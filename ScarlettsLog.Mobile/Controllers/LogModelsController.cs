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
    public class LogModelsController : Controller
    {
        private ScarlettsLogMobileContext context = new ScarlettsLogMobileContext();

        //
        // GET: /LogModels/

        public ViewResult Index()
        {
            return View(context.LogModels.ToList());
        }

        //
        // GET: /LogModels/Details/5

        public ViewResult Details(int id)
        {
            LogModel logmodel = context.LogModels.Single(x => x.LogModelId == id);
            return View(logmodel);
        }

        //
        // GET: /LogModels/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /LogModels/Create

        [HttpPost]
        public ActionResult Create(LogModel logmodel)
        {
            if (ModelState.IsValid)
            {
                context.LogModels.Add(logmodel);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(logmodel);
        }
        
        //
        // GET: /LogModels/Edit/5
 
        public ActionResult Edit(int id)
        {
            LogModel logmodel = context.LogModels.Single(x => x.LogModelId == id);
            return View(logmodel);
        }

        //
        // POST: /LogModels/Edit/5

        [HttpPost]
        public ActionResult Edit(LogModel logmodel)
        {
            if (ModelState.IsValid)
            {
                context.Entry(logmodel).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(logmodel);
        }

        //
        // GET: /LogModels/Delete/5
 
        public ActionResult Delete(int id)
        {
            LogModel logmodel = context.LogModels.Single(x => x.LogModelId == id);
            return View(logmodel);
        }

        //
        // POST: /LogModels/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            LogModel logmodel = context.LogModels.Single(x => x.LogModelId == id);
            context.LogModels.Remove(logmodel);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}