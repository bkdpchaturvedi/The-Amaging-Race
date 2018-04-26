using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITAR.Controller
{
    [Route("api/[controller]")]
    public class StaffController : ControllerBase
    {
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public List<Staff> Get(int id)
        {
            List<Staff> Staff = new List<Staff>();

            List<Location> location1 = new List<Location>();
            List<Location> location2 = new List<Location>();
            List<Location> location3 = new List<Location>();

            Staff staff1 = new Staff();
            Staff staff2 = new Staff();
            Staff staff3 = new Staff();

            if (id == 1)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };





            }
            if (id == 2)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 3)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 4)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };
            }
            if (id == 5)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };
            }
            if (id == 6)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };
            }
            if (id == 7)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 8)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 9)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 10)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.292896", lng = "103.843543", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 11)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.289474", lng = "103.841996", time = "2.5", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 12)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.283869", lng = "103.836267", time = "2", distance = "1.3", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 13)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.282329", lng = "103.812129", time = "3", distance = "1.9", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 14)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.299793", lng = "103.781066", time = "2.5", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 15)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.314865", lng = "103.760965", time = "2.3", distance = "1.5", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 16)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 17)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 18)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 19)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 20)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 21)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 22)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 23)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 24)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 25)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 26)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 27)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 28)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 29)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            if (id == 30)
            {
                Location locationT1 = new Location { lat = "1.2928", lng = "103.843768", time = "3", distance = "1.83", pitstopName = " Jurong Bird Park" };
                location1.Add(locationT1);
                staff1 = new Staff { StaffID = 1, Location = location1 };

                Location locationT2 = new Location { lat = "1.321939", lng = "103.750571", time = "2.9", distance = "2", pitstopName = " Jurong Bird Park" };
                location2.Add(locationT2);
                staff2 = new Staff { StaffID = 2, Location = location2 };

                Location locationT3 = new Location { lat = "1.29228", lng = "103.843476", time = "3", distance = "1.8", pitstopName = " Jurong Bird Park" };
                location3.Add(locationT3);
                staff3 = new Staff { StaffID = 3, Location = location3 };

            }
            Staff.Add(staff1);
            Staff.Add(staff2);
            Staff.Add(staff3);
            return Staff;
        }
    }
}