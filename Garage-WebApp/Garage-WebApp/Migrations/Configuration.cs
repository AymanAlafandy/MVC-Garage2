namespace Garage_WebApp.Migrations
{
    using Garage_WebApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage_WebApp.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage_WebApp.DataAccessLayer.RegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Vehicle.AddOrUpdate(n => n.Type,
            new ParkedVehicle()
            {
                Type = "Car",
                RegistrationNumber = 123,
                Color = "Red",
                Brand = "TOYOTA",
                Model = "Avi",
                NumberOfWheels = 4,
            },
             new ParkedVehicle()
             {
                 Type = "Boat",
                 RegistrationNumber = 445,
                 Color = "Pink",
                 Brand = "Vila",
                 Model = "Energy",
                 NumberOfWheels = 0,
             },

              new ParkedVehicle()
              {
                  Type = "Airplan",
                  RegistrationNumber = 0010,
                  Color = "Blue",
                  Brand = "ThaiAirWay",
                  Model = "Boing77",
                  NumberOfWheels = 3,
              },
              new ParkedVehicle()
              {
                  Type = "Motorcycle",
                  RegistrationNumber = 2525,
                  Color = "Black",
                  Brand = "YAMAHA",
                  Model = "LordCoper",
                  NumberOfWheels = 3,
              },
              new ParkedVehicle()
              {
                  Type = "Bus",
                  RegistrationNumber = 0005,
                  Color = "Green",
                  Brand = "VOLVO",
                  Model = "BUSSPower",
                  NumberOfWheels = 6,
            
              });
        }
    }
}
