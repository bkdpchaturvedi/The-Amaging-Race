using Microsoft.AspNet.Identity;
using Newtonsoft.Json.Linq;
using NUS.TheAmagingRace.BAL;
using NUS.TheAmagingRace.DAL;
using NUS.TheAmazingRace.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NUS.TheAmazingRace.Web.Controllers
{
    [Authorize(Roles = "Staff, Admin")]
    public class PitStopController : Controller
    {
        private PitStopBAL pitStopBAL = new PitStopBAL();
        private EventBAL eventBAL = new EventBAL();
        // GET: PitStop

        public ActionResult Index(int EventID=0)
        {
            Session["eventId"] = EventID;
            Event currentEvent = eventBAL.GetSelectedEvent(EventID);
            ViewBag.pitStop = currentEvent.TotalPitStops;
            ViewBag.team = currentEvent.TotalTeams;
            return PartialView("_Index", pitStopBAL.getPitStopOfEvent(EventID));
        }

        public JsonResult GetPitStopData()
        {
            int EventID = Convert.ToInt32(Session["eventId"]);
            return Json(pitStopBAL.getPitStopOfEvent(EventID),JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetPitStop()
        {
            int pitStopId = Convert.ToInt32(Session["pitStopId"]);
            return Json(pitStopBAL.getPitStopOfPitStopId(pitStopId), JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreatePitStop()
        {
           return PartialView("_CreatePitStop");
        }

        public ActionResult EditPitStops(int pitStopId)
        {
            Session["pitStopId"] = pitStopId;
            return PartialView("_EditPitStop", pitStopBAL.GetSelectedPitStop(pitStopId));
        }

        [HttpPost]
        public ActionResult AddPitStop(PitStop pitStop)
        {
            int eventId = Convert.ToInt32(Session["eventId"]);
            String currentUser = User.Identity.GetUserName();
            List<PitStop> pitStops = pitStopBAL.CreatePitStopList(pitStop, currentUser, eventId);
            return PartialView("_Index", pitStops);
        }

        public ActionResult DeletePitStop(int pitStopId)
        {
            int eventID = Convert.ToInt32(Session["eventId"]);
            List<PitStop> pitStop = pitStopBAL.DeletePitStopfromList(pitStopId, eventID);
            return PartialView("_Index", pitStop);
        }
    }
}