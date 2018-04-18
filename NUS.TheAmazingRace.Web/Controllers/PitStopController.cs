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
    public class PitStopController : Controller
    {
        private PitStopBAL pitStopBAL = new PitStopBAL();
        private EventBAL eventBAL = new EventBAL();
        // GET: PitStop

        public ActionResult Index(int EventID=0)
        {
            Session["eventId"] = EventID;
            return PartialView("_Index", pitStopBAL.getPitStopOfEvent(EventID));
        }

        public JsonResult GetPitStopData(int EventID)
        {

            return Json(pitStopBAL.getPitStopOfEvent(EventID),JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreatePitStop()
        {
           return PartialView("_CreatePitStop");
        }

        [HttpPost]
        public ActionResult AddPitStop(PitStop pitStop)
        {
            int eventId = Convert.ToInt32(Session["eventId"]);
            String currentUser = User.Identity.GetUserName();
            List<PitStop> pitStops = pitStopBAL.CreatePitStopList(pitStop, currentUser, eventId);
            return PartialView("_Index", pitStops);
        }
    }
}