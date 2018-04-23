using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPITAR.Controller
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        
      
        
        // GET: api/<controller>
        [HttpGet]
        public void Get()
        {

            
        }


        // GET api/<controller>/5
        [HttpGet("{id}")]
        public List<Team> Get(int id)
        {
            List <Team> Team = new List<Team>();

            List<Location> location1 = new List<Location>();
            List<Location> location2 = new List<Location>();
            List<Location> location3 = new List<Location>();
      


            Team team1 = new Team();
            Team team2 = new Team();
            Team team3 = new Team();
            


            if (id == 1)
            {
                Location locationT1 = new Location { lat = "1.2869480178896424", lng = "103.8442933634766" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat ="1.2906127376102463", lng = "103.84646415710449"};
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2,Location=location2};

                Location locationT3 = new Location {lat= "1.2906127376102463", lng="103.84646415710449"};
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

               



            }
            if(id==2)
            {
                Location locationT1 = new Location { lat = "1.3061691695703814", lng = "103.7893617228516" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.3087229490351062", lng = "103.78578298962088" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.3065739553386106", lng = "103.78943095763088" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if(id==3)
            {
                Location locationT1 = new Location { lat = "1.285575072915112", lng = "103.84120345869144" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292028584302652", lng = "103.84483337402344" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.292028584302652", lng = "103.84483337402344" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if(id==4)
            {
                Location locationT1 = new Location { lat = "1.302736831776599", lng = "103.78352523603519" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.304947381039791", lng = "103.79058950817557" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.3041713197612248", lng = "103.78848682005764" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 5)
                {
                    Location locationT1 = new Location { lat = "1.2828291807519783", lng = "103.83708358564456" };
                    location1.Add(locationT1);
                    team1 = new Team { TeamID = 1, Location = location1 };

                    Location locationT2 = new Location { lat = "1.2915570543641475", lng = "103.8437354640015" };
                    location2.Add(locationT2);
                    team2 = new Team { TeamID = 2, Location = location2 };

                    Location locationT3 = new Location { lat = "1.2906989653946102", lng = "103.84309173383792" };
                    location3.Add(locationT3);
                    team3 = new Team { TeamID = 3, Location = location3 };

                }
            if (id == 6)
            {
                Location locationT1 = new Location { lat = "1.2979315510125065", lng = "103.78283859052738" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.300828573127226", lng = "103.78955953991385" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.3025409585985845", lng = "103.78908763487698" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 7)
            {
                Location locationT1 = new Location { lat = "1.2804265226916458", lng = "103.83433700361331" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.2905273475659456", lng = "103.84292007246097" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.2889823677153296", lng = "103.84676456451416" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 8)
            {
                Location locationT1 = new Location { lat = "1.2948424371260154", lng = "103.78249526777347" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.296366523635368", lng = "103.78818624889823" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.3012538306197308", lng = "103.78977428038479" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 9)
            {
                Location locationT1 = new Location { lat = "1.279396811404727", lng = "103.83193374433597" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.2889827865870787", lng = "103.84086013593753" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.2880388877498314", lng = "103.84214759626468" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 10)
            {
                Location locationT1 = new Location { lat = "1.2835763969178322", lng = "103.78166198730469" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.2920760840154957", lng = "103.79161947643729" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.299537658959669", lng = "103.79200587828518" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }

            Team.Add(team1);
            Team.Add(team2);
            Team.Add(team3);
            return Team ;

        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
