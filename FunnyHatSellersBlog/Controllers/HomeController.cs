﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunnyHatSellersBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LatestProjects()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}