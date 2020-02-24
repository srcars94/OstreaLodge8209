using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OstreaLodge8209.Controllers
{
    public class JoiningController : Controller
    {
        public ActionResult Joining()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UniScheme()
        {
            ViewBag.Message = "UniScheme";

            return View();
        }

        public ActionResult UsefulLinks()
        {
            ViewBag.Message = "UsefulLinks";

            return View();
        }
    }
}