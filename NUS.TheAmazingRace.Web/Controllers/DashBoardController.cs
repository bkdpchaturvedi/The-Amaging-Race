using NUS.TheAmagingRace.BAL;
using NUS.TheAmagingRace.DAL;
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
        private PitStopBAL pitStopBAL = new PitStopBAL();
        private Event eventObj = new Event();
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

        public JsonResult GetPitStopData()
        {
            int EventID = Convert.ToInt32(Session["eventId"]);
            return Json(pitStopBAL.getPitStopOfEvent(EventID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult ShowEventData(int eventId)
        {
            Session["eventId"] = eventId;
            return PartialView("_MapView");
        }

        public PartialViewResult CurrentEventBoard()
        {
            return PartialView("_LeaderBoard", eventBAL.CurrentEvent());
        }
    }
}