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
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Garage_WebApp.DataAccessLayer.RegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Vehicle.AddOrUpdate(n => n.RegNr,
            new ParkedVehicle()
            {
                Type =Models.Type.Car ,
                RegNr = "123",
                Color = "Red",
                Brand = "TOYOTA",
                Model = "Avi",
                NumberOfWheels = 4,
                ParkingTime = DateTime.Now,
                //ChekInTime = DateTime.Now,
                CheckOutTime = DateTime.Now,
            },
             new ParkedVehicle()
             {
                 Type = Models.Type.Boat,
                 RegNr = "445",
                 Color = "Pink",
                 Brand = "Vila",
                 Model = "Energy",
                 NumberOfWheels = 0,
                 ParkingTime = DateTime.Now,
                 //ChekInTime = DateTime.Now,
                 CheckOutTime = DateTime.Now,

             },

              new ParkedVehicle()
              {
                  Type = Models.Type.Airplan,
                  RegNr = "0010",
                  Color = "Blue",
                  Brand = "ThaiAirWay",
                  Model = "Boing77",
                  NumberOfWheels = 3,
                  ParkingTime = DateTime.Now,
                  //ChekInTime = DateTime.Now,
                  CheckOutTime = DateTime.Now,
              },
              new ParkedVehicle()
              {
                  Type = Models.Type.Motorcycle,
                  RegNr = "2525",
                  Color = "Black",
                  Brand = "YAMAHA",
                  Model = "LordCoper",
                  NumberOfWheels = 3,
                  ParkingTime = DateTime.Now,
                  //ChekInTime = DateTime.Now,
                  CheckOutTime = DateTime.Now,
              },
              new ParkedVehicle()
              {
                  Type = Models.Type.Bus,
                  RegNr = "0005",
                  Color = "Green",
                  Brand = "VOLVO",
                  Model = "BUSSPower",
                  NumberOfWheels = 6,
                  ParkingTime = DateTime.Now,
                  //ChekInTime = DateTime.Now,
                  CheckOutTime = DateTime.Now,
            
              },
              new ParkedVehicle()
              {
                  Type = Models.Type.Car,
                  RegNr = "69",
                  Color = "bronze",
                  Brand = "VOLVO",
                  Model = "Family Car",
                  NumberOfWheels = 4,
                  ParkingTime = DateTime.Now,
                  //ChekInTime = DateTime.Now,
                  CheckOutTime = DateTime.Now,
              });
        }
    }
}
