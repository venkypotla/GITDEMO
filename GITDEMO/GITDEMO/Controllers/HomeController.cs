﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GITDEMO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
        ViewBag.name="venky";
          ViewBag.name="venky potla";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
         public ActionResult Index2()
        {
            return View();
        }

    }
}
