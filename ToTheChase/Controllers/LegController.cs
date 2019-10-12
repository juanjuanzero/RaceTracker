using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToTheChase.Data;
using ToTheChase.Models;

namespace ToTheChase.Controllers
{
    public class LegController : Controller
    {
        private readonly IToTheChaseData db;

        public LegController(IToTheChaseData db)
        {
            this.db = db;
        }

        // GET: Legs
        public ActionResult Legs()
        {
            var model = db.Legs();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new Leg();
            ViewBag.Runners = db.GetAllRunners();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Leg leg)
        {
            if (ModelState.IsValid)
            {
                db.AddLeg(leg);
                return RedirectToAction("Legs");
            }
            return View(leg);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var leg = db.GetLegById(id);
            ViewBag.Runners = db.GetAllRunners();
            return View(leg);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Leg leg)
        {
            if (ModelState.IsValid)
            {
                db.UpdateLeg(leg);
                return RedirectToAction("Legs");
            }
            return View(leg);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.GetLegById(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.GetLegById(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, string s)
        {
            db.RemoveLeg(id);
            return RedirectToAction("Legs");
        }

    }
}