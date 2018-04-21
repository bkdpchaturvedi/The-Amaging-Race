using NUS.TheAmagingRace.BAL;
using NUS.TheAmagingRace.DAL;
using NUS.TheAmagingRace.DAL.Reporsitory;
using NUS.TheAmagingRace.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NUS.TheAmazingRace.Web.Controllers
{
    [Authorize(Roles ="Admin")]
    public class MemberController : Controller
    {
        IMemberBAL memberBAL = null;
        public MemberController()
        {
            memberBAL = new MemberBAL();
        }
        protected MemberController(IMemberBAL memberBAL)
        {
            this.memberBAL = memberBAL;
        }
        // GET: Member
        public ActionResult Index()
        {
            //TODO
            //Get all Administrators
            //Get All Members
            //Get All Staff
           
            return View();
        }

        // GET: Member/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Member/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Member/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Member/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Member/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Member/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Member/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult LoadAdministrators()
        {
           var Administrators= memberBAL.GetAllTARAdministrators();
            return PartialView(Administrators);
        }

        [HttpGet]
        public ActionResult LoadMembers()
        {
            var members = memberBAL.GetAllMember();
            return PartialView(members);
        }

        [HttpGet]
        public ActionResult LoadStaff()
        {
            var Staff = memberBAL.GetAllStaff();
            return PartialView(Staff);
        }
    }
}
