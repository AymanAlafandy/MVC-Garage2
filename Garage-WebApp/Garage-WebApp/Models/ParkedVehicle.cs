using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage_WebApp.Models
{
    public class ParkedVehicle
    {
        public string Type { get; set; }
        public int RegistrationNumber { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
    }
}