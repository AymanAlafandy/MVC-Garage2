using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage_WebApp.Models.ViewModel
{   
   
    public class VehicleList
    {   
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [DisplayName("Type")]
        public Type Type { get; set; }
        [DisplayName("Color")]
        public string Color { get; set; }
        [DisplayName("Registration Number")]
        public string RegNr { get; set; }
        [DisplayName("ParingTime")]
        public DateTime ParkingTime { get; set; }
       

        public VehicleList()
        {

        }
        public VehicleList(ParkedVehicle v)
        {
            Id = v.Id;
            Type = v.Type;
            Color = v.Color;
            RegNr = v.RegNr;
            ParkingTime = v.ParkingTime;

        }
    }
}