﻿using Archery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Archery.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Title"] = "Acceuil";
            return View();
        }
        [Route("a-propos")]
        public ActionResult About()
        {
            var modelInfo = new Info
            {
                DevName = "Alexandre",
                ContactMail = "AlexandrePoirot2500@gmail.com",
                CreatedDate = DateTime.Now
            };
            ViewBag.Title = "A Propos";
            return View(modelInfo);
        }

    }
}