using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Garage_WebApp.Models.ViewModel
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int MemberNr { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<ParkedVehicle> ParkedVehicles { get;set;}
    }
}