using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToTheChase.Data;
using ToTheChase.Models;

namespace ToTheChase.Controllers
{
    public class RunnerController : Controller
    {
        private readonly IToTheChaseData db;

        /// <summary>
        /// Using dependency inject here to inject the appropriate data class.
        /// </summary>
        /// <param name="db"></param>
        public RunnerController(IToTheChaseData db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Runner runner)
        {
            if (ModelState.IsValid)
            {
                db.AddRunner(runner);
                return RedirectToAction("Runners");
            }
            return View(runner);
        }

        public ActionResult Details(int id)
        {
            var model = db.GetRunnerById(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.GetRunnerById(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Runner runner)
        {
            if (ModelState.IsValid)
            {
                db.UpdateRunner(runner);
                return RedirectToAction("Runners");
            }
            return View();
        }

        public ActionResult Runners()
        {
            var model = db.GetAllRunners();
            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.GetRunnerById(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, string s)
        {
            if (ModelState.IsValid)
            {
                db.RemoveRunner(id);
                return RedirectToAction("Runners");
            }
            return View();
        }
    }
}