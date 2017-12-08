using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage_WebApp.Models.ViewModel
{
    public class Receipt
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public string RegNr { get; set; }
        public float CheckInTime { get; set; }
        public float CheckOutTime { get; set; }
        public float TotalTime { get; set; }
        
        public Receipt()
        {

        }
        public Receipt(ParkedVehicle r)
        {
            Id = r.Id;
            Type = r.Type;
            RegNr = r.RegNr;

            //CheckInTime = r.CheckInTime;
            //CheckOutTime = r.CheckOutTime;

            // assign checkouttime instead of send it to database


        }
    }
}