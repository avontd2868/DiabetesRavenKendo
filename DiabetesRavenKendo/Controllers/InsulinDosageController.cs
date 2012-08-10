using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiabetesRavenKendo.Models;
using ScarlettsLog.Mobile.Controllers;

namespace DiabetesRavenKendo.Controllers
{   
    public class InsulinDosageController : RavenController
    {
        //
        // GET: /InsulinDosageModels/

        public ViewResult Index()
        {
            return View(RavenSession.Query<InsulinDosageModel>().ToArray().AsEnumerable());
        }

        //
        // GET: /InsulinDosageModels/Details/5

        public ViewResult Details(int id)
        {
            return View(RavenSession.Load<InsulinDosageModel>(id));
        }

        private ViewResult Details(InsulinDosageModel entryModel)
        {
            return View(entryModel);
        }

        //
        // GET: /InsulinDosageModels/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /InsulinDosageModels/Create

        [HttpPost]
        public ActionResult Create(InsulinDosageModel dosageModel)
        {
            if (!ModelState.IsValid)
            {
                return View(dosageModel);
            }
            RavenSession.Store(dosageModel);
            return RedirectToAction("Details", dosageModel); 
        }
        
        //
        // GET: /InsulinDosageModels/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(RavenSession.Load<InsulinDosageModel>(id));
        }

        //
        // POST: /InsulinDosageModels/Edit/5

        [HttpPost]
        public ActionResult Edit(InsulinDosageModel dosageModel)
        {
            if (!ModelState.IsValid)
            {
                return View(dosageModel);
            }
            RavenSession.Store(dosageModel);
            return RedirectToAction("Details", dosageModel); 
        }

        //
        // GET: /InsulinDosageModels/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(RavenSession.Load<InsulinDosageModel>(id));
        }

        //
        // POST: /InsulinDosageModels/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            RavenSession.Delete<InsulinDosageModel>(RavenSession.Load<InsulinDosageModel>(id));
            return RedirectToAction("Index");
        }
    }
}