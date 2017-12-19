using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Garage_WebApp.Models.ViewModel;
using Garage_WebApp.Models;

namespace Garage_WebApp.DataAccessLayer
{
    public class RegisterContext : DbContext
    {
      public RegisterContext(): base("GarageDb")
        {}

        public DbSet<ParkedVehicle> Vehicle { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<VehicleType>VehicleTypes { get; set; }
    }
}