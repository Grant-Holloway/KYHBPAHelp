﻿using KYHBPA_TeamA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KYHBPA_TeamA.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var first = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var events = db.Events.Where(e => e.EventDate >= first).Select(a => new PhotoGalleryViewModel
            {
                //Map the properties you need
                Description = a.EventDescription,
                Start_Time = a.EventDate,
                End_Time = a.EventTime,


            }).ToList();
            
            
            return View();
        }

        

        public ActionResult About()
        {
            ViewBag.Message = "About the KY HBPA page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "KY HBPA Contact information page.";

            return View();
        }
        public ActionResult Board()
        {
            ViewBag.Message = "KY HBPA Board of Directors page.";

            return View();
        }
        public ActionResult Benefits()
        {
            ViewBag.Message = "Your Benevolence page.";

            return View();
        }
    }
}