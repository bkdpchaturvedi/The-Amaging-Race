using Microsoft.AspNet.SignalR;
using NUS.TheAmagingRace.BAL;
using NUS.TheAmagingRace.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NUS.TheAmazingRace.Web.Controllers
{
    public class HubController : Hub
    {
        private TeamBAL teamBAL = new TeamBAL();
        // GET: Hub
        public void CallSignalR(int EventId)
        {
            var mappingHub = GlobalHost.ConnectionManager.GetHubContext<MappingHub>();
            List<Team> teams = teamBAL.GetTeamByEvent(EventId);
            
            for (int i = 0; i<teams.Count; i++)
            {
               var eachTeam  = new
                {
                    TeamID = teams[i].TeamID,
                    Latitude = teams[i].Latitude,
                    Longitude = teams[i].Longitude,
                    Distance = teams[i].Distance,
                    Time = teams[i].Time,
                    NextPitStop = teams[i].NextPitStop,
                    Position = teams[i].Position
                };
                mappingHub.Clients.All.locationReceived(eachTeam);
            }

            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
        }
    }
}