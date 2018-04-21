using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUS.TheAmagingRace.BusinessModels
{
    public class TeamViewModel
    {


        [Display(Name = "Team ID")]
        public int TeamID { get; set; }
        [Required]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        public EventViewModel EventViewModel { get; set; }
        [Required]
        [Display(Name = "Team Members")]
        public virtual ICollection<TARUserViewModel> Members { get; set; }


    }
}
