using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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
        private TARDBContext db = new TARDBContext();
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
            TARDBContext userList = new TARDBContext();
            List<SelectListItem> ListOfUsers = new List<SelectListItem>();

            var getRole = (from r in db.Roles where r.Name.Contains("Staff") select r).FirstOrDefault();
            var getStaffUsers = db.Users.Where(x => x.Roles.Select(y => y.RoleId).Contains(getRole.Id)).ToList();
            
            foreach (var item in getStaffUsers)
            {
               
              
                ListOfUsers.Add(new SelectListItem() { Text = item.UserName, Value = item.UserName });


            }

            ViewBag.StaffList = ListOfUsers;
            
            return PartialView("_CreatePitStop");
        }

        public ActionResult EditPitStops(int pitStopId)
        {

            TARDBContext userList = new TARDBContext();
            List<SelectListItem> ListOfUsers = new List<SelectListItem>();
            var getRole = (from r in db.Roles where r.Name.Contains("Staff") select r).FirstOrDefault();
            var getStaffUsers = db.Users.Where(x => x.Roles.Select(y => y.RoleId).Contains(getRole.Id)).ToList();

            foreach (var item in getStaffUsers)
            {


                ListOfUsers.Add(new SelectListItem() { Text = item.UserName, Value = item.UserName });


            }

            ViewBag.StaffList = ListOfUsers;
            Session["pitStopId"] = pitStopId;
            return PartialView("_EditPitStop", pitStopBAL.GetSelectedPitStop(pitStopId));
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> AddPitStop(PitStop pitStop)
        {
            UserManager<TARUser> UserManager = new UserManager<TARUser>(new UserStore<TARUser>(new TARDBContext()));

            int eventId = Convert.ToInt32(Session["eventId"]);
            String currentUser = User.Identity.GetUserName();
            var user = await UserManager.FindByNameAsync(pitStop.Staff.UserName);
            var userId = user.Id;
           
            List<PitStop> pitStops = pitStopBAL.CreatePitStopList(pitStop, currentUser, eventId,userId);
            return PartialView("_Index", pitStops);
        }

        public ActionResult DeletePitStop(int pitStopId)
        {
            int eventID = Convert.ToInt32(Session["eventId"]);
            List<PitStop> pitStop = pitStopBAL.DeletePitStopfromList(pitStopId, eventID);
            return PartialView("_Index", pitStop);
        }
        public ActionResult PitstopDetails(int pitStopId)
        {

            return PartialView("_PitStopDetails",pitStopBAL.GetSelectedPitStop(pitStopId));
        }
    }

}