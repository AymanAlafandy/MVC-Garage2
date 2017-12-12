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
        private bool x;
        public int Id { get; set; }
       
        public Type Type { get; set; }
        
        public string Color { get; set; }
        [DisplayName("Registration Number")]
        public string RegNr { get; set; }
       
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

        //public VehicleList(bool x)
        //{
        //    this.x = x;
        //}
    }
}