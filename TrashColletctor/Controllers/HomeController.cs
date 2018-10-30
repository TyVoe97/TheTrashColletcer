﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashColletctor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View ("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("Index");
        }
    }
}