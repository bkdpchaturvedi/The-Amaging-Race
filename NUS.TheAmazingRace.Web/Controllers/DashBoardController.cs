using NUS.TheAmagingRace.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NUS.TheAmazingRace.Web.Controllers
{
    public class DashBoardController : Controller
    {
        private EventBAL eventBAL = new EventBAL();
        // GET: DashBoard
        public ActionResult Index()
        {
             return View();
        }

        public PartialViewResult CurrentEvent()
        {
            return PartialView("_CurrentEvent", eventBAL.CurrentEvent());
        }

        public PartialViewResult UpcomingEvent()
        {
            return PartialView("_UpcomingEvent", eventBAL.UpcomingEvents());
        }
    }
}