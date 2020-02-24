using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OstreaLodge8209.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ScottishConnection()
        {
            ViewBag.Message = "ScottishConnection";

            return View();
        }
        

    }
}