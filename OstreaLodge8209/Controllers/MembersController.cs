﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OstreaLodge8209.Controllers
{
    public class MembersController : Controller
    {
        public ActionResult Members()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}