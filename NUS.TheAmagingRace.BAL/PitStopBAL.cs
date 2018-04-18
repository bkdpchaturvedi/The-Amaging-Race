using NUS.TheAmagingRace.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUS.TheAmagingRace.BAL
{
    public class PitStopBAL
    {
        private TARDBContext db = new TARDBContext();
        private PitStop pitStop = new PitStop();
        public List<PitStop> GetPitStopList()
        {
            return db.PitStops.ToList(); ;
        }

        public List<PitStop> CreatePitStopList(PitStop pitStop, string currentUser, int eventId)
        {
            
            if (pitStop.PitStopID > 0)
            {
                PitStop editPitStops = db.PitStops.SingleOrDefault(x => x.PitStopID == pitStop.PitStopID);
                editPitStops.PitStopName = pitStop.PitStopName;
                editPitStops.SequenceNumber = pitStop.SequenceNumber;
                editPitStops.Address = pitStop.Address;
                editPitStops.LastModifiedBy = currentUser;
                editPitStops.Event.EventID = eventId;
                editPitStops.LastModifiedAt = DateTime.Now;
                db.SaveChanges();

                pitStop.CreatedBy = currentUser;
                //db.PitStops.Add(pitStop);

                db.SaveChanges();
            }
            else
            {
                pitStop.CreatedBy = currentUser;
                Event currentEvent = db.Events.SingleOrDefault(x => x.EventID == eventId);
                pitStop.Event = currentEvent;
                db.PitStops.Add(pitStop);

                db.SaveChanges();
            }

            return db.PitStops.ToList();
        }

        public List<PitStop> getPitStopOfEvent(int eventId)
        {
            var pitstops = from s in db.PitStops
                         select s;
            pitstops = pitstops.Where(s => s.Event.EventID == eventId);
            
            return pitstops.ToList();
        }

        public PitStop GetValuesToEdit(int pitStopId)
        {
            PitStop editPitStops = db.PitStops.SingleOrDefault(x => x.PitStopID == pitStopId);
            pitStop.PitStopID = editPitStops.PitStopID;
            pitStop.PitStopName = editPitStops.PitStopName;
            pitStop.Address = editPitStops.Address;
            pitStop.SequenceNumber = editPitStops.SequenceNumber;
            
            return pitStop;

        }

        public PitStop GetSelectedPitStop(int PitSTopId)
        {
            PitStop currentPitStop = db.PitStops.SingleOrDefault(x => x.PitStopID == PitSTopId);
            return currentPitStop;

        }

    }
}
