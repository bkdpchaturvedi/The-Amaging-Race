using NUS.TheAmagingRace.BAL;
using NUS.TheAmagingRace.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NUS.TheAmazingRace.Web.Controllers
{
    public class TeamController : Controller
    {
        TeamBAL teamBAL = null;
        public TeamController()
        {
            teamBAL = new TeamBAL();
        }
        public TeamController(TeamBAL teamBAL)
        {
            this.teamBAL = teamBAL;
        }

        // GET: Team
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadTeams(string EventID)
        {
           return PartialView(teamBAL.GetTeams(int.Parse(EventID)));
        }
        [HttpGet]
        public ActionResult CreateTeam(int EventID)
        {
            TeamViewModel viewModel = new TeamViewModel();
            viewModel.EventViewModel = teamBAL.GetEventById(EventID);
            return PartialView(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTeam(TeamViewModel viewModel)
        {
           
            viewModel.EventViewModel = teamBAL.GetEventById(viewModel.EventViewModel.EventID);

            teamBAL.SaveTeam(viewModel);
            return PartialView(viewModel);
        }
    }
}