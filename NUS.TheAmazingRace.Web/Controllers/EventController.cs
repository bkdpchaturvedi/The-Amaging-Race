using NUS.TheAmagingRace.BAL;
using NUS.TheAmagingRace.DAL;
using NUS.TheAmazingRace.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.IO;

namespace NUS.TheAmazingRace.Web.Controllers
{
    [Authorize(Roles = "Staff, Admin")]

    public class EventController : Controller
    {
      
       
        private EventBAL eventBAL = new EventBAL();
        private PitStopBAL pitStopBAL = new PitStopBAL();
        private List<PitStop> pitStop = new List<PitStop>();

        [HttpGet]
        public ActionResult Index()
        {
           
            return View();
        }


        public PartialViewResult EventsList()
        {
            List<Event> events = eventBAL.GetEventList();
            return PartialView("_EventsList",events.ToList());
        }

        [HttpPost]
        public ActionResult EventsList(Event eventModel)
        {
            if (eventModel.EventID > 0)
            {
                Event selectedEvent = eventBAL.GetEditingValues(eventModel.EventID);
                if (eventModel.ImageFile == null)
                {
                    eventModel.ImagePath = selectedEvent.ImagePath;
                }
                else
                {
                    string fileName = Path.GetFileNameWithoutExtension(eventModel.ImageFile.FileName);
                    string extension = Path.GetExtension(eventModel.ImageFile.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    eventModel.ImagePath = "~/Content/Images/" + fileName;
                    fileName = Path.Combine(Server.MapPath("~/Content/Images/"), fileName);
                    eventModel.ImageFile.SaveAs(fileName);
                }

            }
            else
            {
                if (eventModel.ImageFile == null)
                {
                    eventModel.ImagePath = "~/Content/Images/Empty_Event_Icon.png";
                }
                else
                {
                    string fileName = Path.GetFileNameWithoutExtension(eventModel.ImageFile.FileName);
                    string extension = Path.GetExtension(eventModel.ImageFile.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    eventModel.ImagePath = "~/Content/Images/" + fileName;
                    fileName = Path.Combine(Server.MapPath("~/Content/Images/"), fileName);
                    eventModel.ImageFile.SaveAs(fileName);
                }
            }
            

            string currentUser = User.Identity.GetUserName();
            return PartialView("_EventsList", eventBAL.EditEventList(eventModel, currentUser).ToList());
        }



        [HttpGet]
        public ActionResult Search(string searchString)
        {
            return PartialView("_EventsList", eventBAL.SearchEvent(searchString).ToList());
        }


        public ActionResult CreateEvent(Event eventModel)
        {
          
            return PartialView("_CreateEvent");
        }

        public ActionResult DeleteEvent(int eventId)
        {
            
            return PartialView("_EventsList", eventBAL.DeleteEventfromList(eventId));
        }

        public ActionResult EventDetails(int eventId)
        {

            return PartialView("_EventDetails",eventBAL.GetSelectedEvent(eventId));
        }

        public ActionResult EditEvent(int eventId)
        {
                        
            return PartialView("_EditEvent", eventBAL.GetEditingValues(eventId));

        }

        public JsonResult GetEvents(string search)
        {

            return Json(eventBAL.SearchEvent(search), JsonRequestBehavior.AllowGet);
        }


    }
}