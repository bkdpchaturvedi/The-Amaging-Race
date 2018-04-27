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
            List<Team> Team = new List<Team>();

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

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "3", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };





            }
            if (id == 2)
            {
                Location locationT1 = new Location { lat = "1.290052", lng = "103.842015", time = "6", distance = "3.7", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.289474", lng = "103.841996", time = "6", distance = "4", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.289269", lng = "103.841892", time = "6", distance = "5", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 3)
            {
                Location locationT1 = new Location { lat = "1.285159", lng = "103.837501", time = "8.5", distance = "5.2", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.283869", lng = "103.836267", time = "8.5", distance = "6.2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.283783", lng = "103.835151", time = "8.5", distance = "7.4", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 4)
            {
                Location locationT1 = new Location { lat = "1.281728", lng = "103.816249", time = "11", distance = "6.65", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.282329", lng = "103.812129", time = "11", distance = "7.65", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.28293", lng = "103.803975", time = "11", distance = "9.4", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };
            }
            if (id == 5)
            {
                Location locationT1 = new Location { lat = "1.297734", lng = "103.782869", time = "13.5", distance = "8.1", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.299793", lng = "103.781066", time = "13.5", distance = "10.1", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.3058", lng = "103.771195", time = "13.5", distance = "11.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };
            }
            if (id == 6)
            {
                Location locationT1 = new Location { lat = "1.312892", lng = "103.762253", time = "16", distance = "9.4", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.314865", lng = "103.760965", time = "16", distance = "11.4", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.314851", lng = "103.759333", time = "16", distance = "16.3", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };
            }
            if (id == 7)
            {
                Location locationT1 = new Location { lat = "1.322411", lng = "103.75173", time = "18.5", distance = "11.5", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "18.5", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.322153", lng = "103.748811", time = "18.5", distance = "18.2", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 8)
            {
                Location locationT1 = new Location { lat = "1.32555", lng = "103.741622", time = "20.5", distance = "12.8", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "20.5", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.325448", lng = "103.740474", time = "20.5", distance = "19.2", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 9)
            {
                Location locationT1 = new Location { lat = "1.323209", lng = "103.716875", time = "22.5", distance = "14.63", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "22.5", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.321756", lng = "103.71355", time = "22.5", distance = "20", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 10)
            {
                Location locationT1 = new Location { lat = "1.32146", lng = "103.707641", time = "24.5", distance = "15.73", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "24.5", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.321557", lng = "103.707598", time = "24.5", distance = "22.6", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 11)
            {
                Location locationT1 = new Location { lat = "1.32206", lng = "103.707286", time = "27.6", distance = "17.3", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "27.6", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.326436", lng = "103.727284", time = "27.6", distance = "24.4", pitstopName = " Sembawang Country Club" };

                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 12)
            {
                Location locationT1 = new Location { lat = "1.322403", lng = "103.753376", time = "30.2", distance = "19.25", pitstopName = " Sembawang Country Club" };

                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "30.2", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.320885", lng = "103.755055", time = "30.2", distance = "26.7", pitstopName = " Sembawang Country Club" };

                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 13)
            {
                Location locationT1 = new Location { lat = "1.324331", lng = "103.763657", time = "32.6", distance = "21.45", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "32.6", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.330166", lng = "103.763141", time = "32.6", distance = "28.45", pitstopName = " Sembawang Country Club" };

                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 14)
            {
                Location locationT1 = new Location { lat = "1.336172", lng = "103.774041", time = "35.38", distance = "24.86", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "35.38", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.340078", lng = "103.778027", time = "35.38", distance = "29.45", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 15)
            {
                Location locationT1 = new Location { lat = "1.352262", lng = "103.788327", time = "39", distance = "27.46", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "39", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.355952", lng = "103.783091", time = "39", distance = "32.45", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 16)
            {
                Location locationT1 = new Location { lat = "1.370176", lng = "103.778883", time = "41.2", distance = "30.14", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "41.2", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.376697", lng = "103.777681", time = "41.2", distance = "32.45", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 17)
            {
                Location locationT1 = new Location { lat = "1.390125", lng = "103.774848", time = "43.4", distance = "34.5", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "43.4", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.396388", lng = "103.774762", time = "43.4", distance = "35.45", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 18)
            {
                Location locationT1 = new Location { lat = "1.40943", lng = "103.772187", time = "46", distance = "38.4", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "46", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.410117", lng = "103.774847", time = "46", distance = "37.5", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 19)
            {
                Location locationT1 = new Location { lat = "1.415094", lng = "103.79373", time = "48", distance = "40.5", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "48", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.414262", lng = "103.806243", time = "48", distance = "38", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 20)
            {
                Location locationT1 = new Location { lat = "1.413476", lng = "103.814644", time = "51", distance = "45.4", pitstopName = " Sembawang Country Club" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "51", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.413604", lng = "103.815547", time = "51", distance = "40", pitstopName = " Sembawang Country Club" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 21)
            {
                Location locationT1 = new Location { lat = "1.413826", lng = "103.805618", time = "54.5", distance = "47.8", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "54.5", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.413946", lng = "103.817886", time = "54.5", distance = "42.75", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 22)
            {
                Location locationT1 = new Location { lat = "1.402777", lng = "103.812463", time = "57.2", distance = "49.3", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "57.2", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.413383", lng = "103.8234", time = "57.2", distance = "44.87", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 23)
            {
                Location locationT1 = new Location { lat = "1.393596", lng = "103.823277", time = "60.2", distance = "51", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "60.2", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.40674", lng = "103.828023", time = "60.2", distance = "48", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 24)
            {
                Location locationT1 = new Location { lat = "1.397157", lng = "103.843833", time = "64", distance = "53", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "64", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.397216", lng = "103.830083", time = "64", distance = "51.3", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 25)
            {
                Location locationT1 = new Location { lat = "1.401586", lng = "103.865217", time = "68", distance = "58", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "68", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.395586", lng = "103.837808", time = "68", distance = "54.3", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 26)
            {
                Location locationT1 = new Location { lat = "1.391321", lng = "103.910237", time = "72", distance = "63", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "72", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.321939", lng = "103.750571", time = "72", distance = "56.2", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 27)
            {
                Location locationT1 = new Location { lat = "1.374654", lng = "103.935646", time = "74", distance = "64", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "74", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.36805", lng = "103.860874", time = "74", distance = "58.8", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 28)
            {
                Location locationT1 = new Location { lat = "1.351558", lng = "103.964684", time = "79.2", distance = "67.4", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "79.2", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.349438", lng = "103.860078", time = "79.2", distance = "59", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 29)
            {
                Location locationT1 = new Location { lat = "1.33587", lng = "103.958681", time = "80.6", distance = "69.4", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "80.6", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.340943", lng = "103.861709", time = "80.6", distance = "61.3", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }
            if (id == 30)
            {
                Location locationT1 = new Location { lat = "1.339485", lng = "103.950123", time = "85", distance = "72.5", pitstopName = " Changi General Hospital" };
                location1.Add(locationT1);
                team1 = new Team { TeamID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "85", distance = "13.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                team2 = new Team { TeamID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.32396", lng = "103.872713", time = "85", distance = "63", pitstopName = " Changi General Hospital" };
                location3.Add(locationT3);
                team3 = new Team { TeamID = 3, Location = location3 };

            }


            Team.Add(team1);
            Team.Add(team2);
            Team.Add(team3);
            return Team;

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
