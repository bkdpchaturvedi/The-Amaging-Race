using AutoMapper;
using NUS.TheAmagingRace.BusinessModels;
using NUS.TheAmagingRace.DAL;
using NUS.TheAmagingRace.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace NUS.TheAmagingRace.BAL
{
    /// <summary>
    /// 
    /// </summary>
    public class TeamBAL
    {
        private readonly UOW _unitOfWork;
        public TeamBAL()
        {
            _unitOfWork = new UOW();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EventID"></param>
        /// <returns></returns>
        public List<TeamViewModel> GetTeams(int EventID)
        {
            // Event @event=  _unitOfWork.EventRepository.GetByID(EventID);
            
           Event e= _unitOfWork.EventRepository.GetWithInclude(m=>m.EventID.Equals(EventID), "Teams","PitStops").FirstOrDefault();
            Team t = _unitOfWork.TeamRepository.GetWithInclude(m=>true, "Event","Members").FirstOrDefault();

            return Mapper.Map<List<Team>, List<TeamViewModel>>(e.Teams.ToList()).ToList();
        }

        public EventViewModel GetEventById(int EventID)
        {
          return  Mapper.Map<Event, EventViewModel>(_unitOfWork.EventRepository.GetByID(EventID));
        }

        public void SaveTeam(TeamViewModel teamViewModel)
        {
            Team team = new Team {
                Event = Mapper.Map<Event>(teamViewModel.EventViewModel),
                TeamName=teamViewModel.TeamName,
                Members=null
            };
            //Team team = Mapper.Map<Team>(teamViewModel);
            team.Event = _unitOfWork.EventRepository.GetByID(teamViewModel.EventViewModel.EventID);
            using (var Scope = new TransactionScope())
            {
                _unitOfWork.TeamRepository.Insert(team);
                _unitOfWork.Save();
                Scope.Complete();
            }
        }
    }
}
