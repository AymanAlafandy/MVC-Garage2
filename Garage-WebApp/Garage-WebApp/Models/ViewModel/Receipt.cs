using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage_WebApp.Models.ViewModel
{
    public class Receipt
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string RegNr { get; set; }
        //public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public TimeSpan TotalTime { get; set; }
        public int Price { get; set; }
        
        public Receipt()
        {

        }
        public Receipt(ParkedVehicle r)
        {
            Id = r.Id;
            Type = r.Type.ToString();
            RegNr = r.RegNr;
            //CheckIn = r.ParkingTime;
            CheckOut = DateTime.Now;
            TotalTime = DateTime.Now - r.ParkingTime;
            Price = 50;




        }
    }
}