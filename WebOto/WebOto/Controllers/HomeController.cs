﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebOto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Product()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Accessories()
        {
            ViewBag.Message = "Your contact page.";

            return View("~/Views/Shared/Error.cshtml");
        }

        public ActionResult PriceList()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Promotion()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult News()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Cost()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}