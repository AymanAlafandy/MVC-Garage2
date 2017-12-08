using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage_WebApp.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public string RegNr { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public DateTime ParkingTime { get; set; }
    }

    public enum Type
    {
        Car,
        Bus,
        Airplan,
        Motorcycle,
        Boat,
    }
}