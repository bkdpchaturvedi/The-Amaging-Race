using AutoMapper;
using NUS.TheAmagingRace.BusinessModels;
using NUS.TheAmagingRace.DAL;
using NUS.TheAmagingRace.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUS.TheAmagingRace.BAL
{
    public class TeamBAL
    {
        private readonly UOW _unitOfWork;
        public TeamBAL()
        {
            _unitOfWork = new UOW();
        }

        public List<TeamViewModel> GetTeams(int EventID)
        {
            // Event @event=  _unitOfWork.EventRepository.GetByID(EventID);
            return Mapper.Map<List<Team>, List<TeamViewModel>>(_unitOfWork.TeamRepository.GetMany(m => m.Event.EventID.Equals(EventID)).ToList());
        }

        public EventViewModel GetEventById(int EventID)
        {
          return  Mapper.Map<Event, EventViewModel>(_unitOfWork.EventRepository.GetByID(EventID));
        }
    }
}
