using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToTheChase.Data.Interfaces;

namespace ToTheChase.Controllers
{
    public class LegController : Controller
    {
        private readonly ILegData db;

        public LegController(ILegData db)
        {
            this.db = db;
        }

        // GET: Legs
        public ActionResult Legs()
        {
            var model = db.Legs();
            return View(model);
        }

    }
}