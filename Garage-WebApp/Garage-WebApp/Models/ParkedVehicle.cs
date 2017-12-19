using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using Garage_WebApp.Models.ViewModel;

namespace Garage_WebApp.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int VehicleTypeId { get; set; }

        [DisplayName("Registration Number")]
        [Required(ErrorMessage = "Registration Number is required")]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special characters not allowed")]
        public string RegNr { get; set; }

        [Required(ErrorMessage = "Color is required")]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special characters not allowed")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Brand is required")]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special characters not allowed")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Model is required")]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special characters not allowed")]
        public string Type { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Number of wheels must be from 0")]
        [DisplayName("No. Of Wheels")]
        public int NumberOfWheels { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ParkingTime { get; set; }

        [DisplayName("Checked out time")]
        [Column(TypeName = "datetime2")]
        public DateTime CheckOutTime { get; set; }
        

        public virtual Member Member { get; set; }
        public virtual VehicleType VehicleTypes { get; set; }
    }
   
}