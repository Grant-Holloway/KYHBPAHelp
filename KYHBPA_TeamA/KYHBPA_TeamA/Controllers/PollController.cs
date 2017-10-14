using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KYHBPA_TeamA.Controllers
{
    public class PollController : Controller
    {
        // GET: Poll
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to our Poll!";
            ViewBag.Title = "KYHBPA Poll";
            return View();
        }
    }
}