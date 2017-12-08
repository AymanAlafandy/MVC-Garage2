using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Garage_WebApp.DataAccessLayer
{
    public class RegisterContext : DbContext
    {
      public RegisterContext(): base("GarageDb")
        {}

        public DbSet<Models.ParkedVehicle> Vehicle { get; set; }

        
    }
}