using System.ComponentModel.DataAnnotations;

namespace NUS.TheAmagingRace.DAL
{
    public class PitStop:BaseEntity
    {
        [Key]
        public int PitStopID { get; set; }

        public string PitStopName { get; set; }

       

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public int SequenceNumber { get; set; }

        public string Address { get; set; }

        public virtual Event Event { get; set; }

        public virtual TARUser Staff { get; set; }
    }
}