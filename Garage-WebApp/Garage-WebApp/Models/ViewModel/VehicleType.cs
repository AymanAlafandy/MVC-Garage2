using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage_WebApp.Models.ViewModel
{
    public class VehicleType
    {
        public int Id {get; set;}
        public string Type { get; set; }

        public virtual ICollection<ParkedVehicle> ParkedVehicles { get; set; }
    }

    //public enum Type
    //{
    //    Car,
    //    Bus,
    //    Airplan,
    //    Motorcycle,
    //    Boat,
    //}
}