using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiabetesRavenKendo.Models;
using DiabetesRavenKendo.ViewModels;
using ScarlettsLog.Mobile.Controllers;

namespace DiabetesRavenKendo.Controllers
{   
    public class DiabetesLogEntryController : RavenController
    {
        //
        // GET: /DiabetesLogEntryModels/
        public ViewResult Index()
        {
            return View(RavenSession.Query<DiabetesLogEntryModel>().ToArray().AsEnumerable());
        }

        //
        // GET: /DiabetesLogEntryModels/Details/5
        public ViewResult Details(int id)
        {
            return View(RavenSession.Load<DiabetesLogEntryModel>(id));
        }

        private ViewResult Details(DiabetesLogEntryModel entryModel)
        {
            return View(entryModel);
        }

        //
        // GET: /DiabetesLogEntryModels/Create
        public ActionResult Create()
        {
            return View(new DiabetesLogEntryModel());
        } 

        //
        // POST: /DiabetesLogEntryModels/Create
        [HttpPost]
        public ActionResult Create(DiabetesLogEntryModel entryModel)
        {
            if (!ModelState.IsValid)
            {
                return View(entryModel);
            }
            entryModel.InsulinDosages = new List<InsulinDosageModel>();
            entryModel.FoodItems = new List<FoodItemModel>();
            RavenSession.Store(entryModel);
            return RedirectToAction("Details", entryModel); 
        }
        
        //
        // GET: /DiabetesLogEntryModels/Edit/5
        public ActionResult Edit(int id)
        {
            return View(RavenSession.Load<DiabetesLogEntryModel>(id));
        }

        //
        // POST: /DiabetesLogEntryModels/Edit/5
        [HttpPost]
        public ActionResult Edit(DiabetesLogEntryModel entryModel)
        {
            if (!ModelState.IsValid)
            {
                return View(entryModel);
            }
            RavenSession.Store(entryModel);
            return RedirectToAction("Details", entryModel); 

        }

        //
        // GET: /DiabetesLogEntryModels/Delete/5
        public ActionResult Delete(int id)
        {
            return View(RavenSession.Load<DiabetesLogEntryModel>(id));
        }

        //
        // POST: /DiabetesLogEntryModels/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            RavenSession.Delete<DiabetesLogEntryModel>(RavenSession.Load<DiabetesLogEntryModel>(id));
            return RedirectToAction("Index");
        }
    }
}