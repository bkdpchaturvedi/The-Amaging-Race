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
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2,Location=location2};

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

               



            }
            if(id==2)
            {
                Location locationT1 = new Location { lat = "1.290052", lng = "103.842015", time = "3", distance = "1.87", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.289474", lng = "103.841996", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.289269", lng = "103.841892", time = "2", distance = "1.4", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if(id==3)
            {
                Location locationT1 = new Location { lat = "1.285159", lng = "103.837501", time = "2.5", distance = "1.5", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.283869", lng = "103.836267", time = "2", distance = "1.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.283783", lng = "103.835151", time = "2.6", distance = "1.7", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if(id==4)
            {
                Location locationT1 = new Location { lat = "1.281728", lng = "103.816249", time = "2.5", distance = "1.5", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.282329", lng = "103.812129", time = "3", distance = "1.9", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.28293", lng = "103.803975", time = "2.5", distance = "1.3", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };
            }
            if (id == 5)
                {
                Location locationT1 = new Location { lat = "1.297734", lng = "103.782869", time = "2.5", distance = "1.45", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.299793", lng = "103.781066", time = "2.5", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.3058", lng = "103.771195", time = "2.9", distance = "1.56", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };
            }
            if (id == 6)
            {
                Location locationT1 = new Location { lat = "1.312892", lng = "103.762253", time = "2.5", distance = "1.3", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.314865", lng = "103.760965", time = "2.3", distance = "1.5", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.314851", lng = "103.759333", time = "2.2", distance = "3", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };
            }
            if (id == 7)
            {
                Location locationT1 = new Location { lat = "1.322411", lng = "103.75173", time = "2.5", distance = "1.9", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.322153", lng = "103.748811", time = "2.4", distance = "2.5", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 8)
            {
                Location locationT1 = new Location { lat = "1.32555", lng = "103.741622", time = "2", distance = "1.5", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.324989", lng = "103.741163", time = "2.5", distance = "1.68", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.325448", lng = "103.740474", time = "1.8", distance = "1.6", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 9)
            {
                Location locationT1 = new Location { lat = "1.323209", lng = "103.716875", time = "2.5", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321725", lng = "103.713192", time = "3", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.321756", lng = "103.71355", time = "2.5", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 10)
            {
                Location locationT1 = new Location { lat = "1.321532", lng = "103.707385", time = "2.5", distance = "1", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321532", lng = "103.707385", time = "2.5", distance = "1", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.321557", lng = "103.707598", time = "2.5", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 11)
            {
                Location locationT1 = new Location { lat = "1.32206", lng = "103.707286", time = "3.1", distance = "2.75", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.323175", lng = "103.713809", time = "3.1", distance = "2.75", pitstopName = " Sembawang Country Club" };

                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.326436", lng = "103.727284", time = "4", distance = "2.2", pitstopName = " Sembawang Country Club" };

                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 12)
            {
                Location locationT1 = new Location { lat = "1.322403", lng = "103.753376", time = "2.6", distance = "2.8", pitstopName = " Sembawang Country Club" };

                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321888", lng = "103.755007", time = "2.2", distance = "3.1", pitstopName = " Sembawang Country Club" };

                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.320885", lng = "103.755055", time = "3.1", distance = "2.75", pitstopName = " Sembawang Country Club" };

                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 13)
            {
                Location locationT1 = new Location { lat = "1.324331", lng = "103.763657", time = "2.4", distance = "2.56", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.327592", lng = "103.764944", time = "2.78", distance = "2.75", pitstopName = " Sembawang Country Club" };

                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.330166", lng = "103.763141", time = "3.1", distance = "2.75", pitstopName = " Sembawang Country Club" };

                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 14)
            {
                Location locationT1 = new Location { lat = "1.336172", lng = "103.774041", time = "2.78", distance = "2.75", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.338489", lng = "103.778504", time = "3.1", distance = "2.75", pitstopName = " Sembawang Country Club" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.340078", lng = "103.778027", time = "3.1", distance = "2.75", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 15)
            {
                Location locationT1 = new Location { lat = "1.352262", lng = "103.788327", time = "3.1", distance = "3", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.354064", lng = "103.785666", time = "2.2", distance = "3.1", pitstopName = " Sembawang Country Club" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.355952", lng = "103.783091", time = "4", distance = "2.2", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 16)
            {
                Location locationT1 = new Location { lat = "1.370176", lng = "103.778883", time = "2.2", distance = "3.1", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.37438", lng = "103.776737", time = "3.1", distance = "2.75", pitstopName = " Sembawang Country Club" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.376697", lng = "103.777681", time = "2.2", distance = "3.1", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 17)
            {
                Location locationT1 = new Location { lat = "1.390125", lng = "103.774848", time = "2.2", distance = "3.1", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.391326", lng = "103.773389", time = "3.1", distance = "2", pitstopName = " Sembawang Country Club" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.396388", lng = "103.774762", time = "2.2", distance = "3.1", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 18)
            {
                Location locationT1 = new Location { lat = "1.40943", lng = "103.772187", time = "3.1", distance = "2", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.409602", lng = "103.772873", time = "3.1", distance = "2", pitstopName = " Sembawang Country Club" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.410117", lng = "103.774847", time = "4", distance = "2.2", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 19)
            {
                Location locationT1 = new Location { lat = "1.415094", lng = "103.79373", time = "3.1", distance = "2.75", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.41578", lng = "103.802656", time = "3.1", distance = "2.75", pitstopName = " Sembawang Country Club" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.414262", lng = "103.806243", time = "4", distance = "2.2", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 20)
            {
                Location locationT1 = new Location { lat = "1.413476", lng = "103.814644", time = "3.1", distance = "2.75", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.413607", lng = "103.815091", time = "3.1", distance = "2", pitstopName = " Sembawang Country Club" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.413604", lng = "103.815547", time = "2.2", distance = "3.1", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 21)
            {
                Location locationT1 = new Location { lat = "1.413826", lng = "103.805618", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.411658", lng = "103.805082", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.411143", lng = "103.807485", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 22)
            {
                Location locationT1 = new Location { lat = "1.402777", lng = "103.812463", time = "3.1", distance = "2.4", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.402176", lng = "103.812463", time = "4", distance = "2.75", pitstopName = " Changi General Hospital" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.401447", lng = "103.812849", time = "3.1", distance = "2.4", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 23)
            {
                Location locationT1 = new Location { lat = "1.393596", lng = "103.823277", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };
            
                Location locationT2 = new Location { lat = "1.393467", lng = "103.825251", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.394068", lng = "103.830229", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 24)
            {
                Location locationT1 = new Location { lat = "1.397157", lng = "103.843833", time = "4", distance = "2.75", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.398659", lng = "103.853532", time = "4", distance = "2.75", pitstopName = " Changi General Hospital" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.399045", lng = "103.854262", time = "4", distance = "2.75", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 25)
            {
                Location locationT1 = new Location { lat = "1.401586", lng = "103.865217", time = "3.1", distance = "2.4", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.402291", lng = "103.881041", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.401776", lng = "103.884903", time = "2.95", distance = "2.65", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 26)
            {
                Location locationT1 = new Location { lat = "1.391321", lng = "103.910237", time = "4", distance = "2.75", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.390077", lng = "103.911482", time = "4", distance = "2.75", pitstopName = " Changi General Hospital" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.38909", lng = "103.911868", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 27)
            {
                Location locationT1 = new Location { lat = "1.374654", lng = "103.935646", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.373281", lng = "103.937835", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.370063", lng = "103.94277", time = "2.95", distance = "2.65", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 28)
            {
                Location locationT1 = new Location { lat = "1.351558", lng = "103.964684", time = "3.1", distance = "2.4", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.359366", lng = "103.962109", time = "4", distance = "2.75", pitstopName = " Changi General Hospital" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.35692", lng = "103.963139", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 29)
            {
                Location locationT1 = new Location { lat = "1.33587", lng = "103.958681", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.33823", lng = "103.960483", time = "4", distance = "2.75", pitstopName = " Changi General Hospital" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.335055", lng = "103.958209", time = "3.1", distance = "2.4", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 30)
            {
                Location locationT1 = new Location { lat = "1.339485", lng = "103.950123", time = "3.5", distance = "2.72", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.339323", lng = "103.950177", time = "3.4", distance = "3", pitstopName = " Changi General Hospital" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.339742", lng = "103.950253", time = "3.1", distance = "2.4", pitstopName = " Changi General Hospital" };
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
