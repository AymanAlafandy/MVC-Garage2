namespace Garage_WebApp.Migrations
{
    using Garage_WebApp.Models;
    using Models.ViewModel;
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
            context.VehicleTypes.AddOrUpdate(t => t.Type,
                new VehicleType() { Type = "Car" },
                new VehicleType() { Type = "Buss" }
                );

            context.Members.AddOrUpdate(m => m.Phone,
                new Member()
                {
                    Name = "Kalle",
                    Adress = "xxx",
                    DateOfBirth = DateTime.Now,
                    MemberNr = 123,
                    Phone = "123456789"
                }
                );

            context.SaveChanges();

            context.Vehicle.AddOrUpdate(n => n.RegNr,
            new ParkedVehicle()
            {

                RegNr = "123",
                Color = "Red",
                Brand = "TOYOTA",
                Type = "Avi",
                NumberOfWheels = 4,
                ParkingTime = DateTime.Now,
                //ChekInTime = DateTime.Now,
                CheckOutTime = DateTime.Now,
                MemberId = context.Members.FirstOrDefault(m => m.Name == "Kalle").Id,
                VehicleTypeId = context.VehicleTypes.FirstOrDefault(t => t.Type == "Car").Id
                

                //},
                // new ParkedVehicle()
                // {

                //     RegNr = "445",
                //     Color = "Pink",
                //     Brand = "Vila",
                //     Type = "Energy",
                //     NumberOfWheels = 0,
                //     ParkingTime = DateTime.Now,
                //     //ChekInTime = DateTime.Now,
                //     CheckOutTime = DateTime.Now,
                //     MemberId = 9632,

                // },

                //  new ParkedVehicle()
                //  {

                //      RegNr = "0010",
                //      Color = "Blue",
                //      Brand = "ThaiAirWay",
                //      Type = "Boing77",
                //      NumberOfWheels = 3,
                //      ParkingTime = DateTime.Now,
                //      //ChekInTime = DateTime.Now,
                //      CheckOutTime = DateTime.Now,
                //      MemberId = 7896,
                //  },
                //  new ParkedVehicle()
                //  {

                //      RegNr = "2525",
                //      Color = "Black",
                //      Brand = "YAMAHA",
                //      Type = "LordCoper",
                //      NumberOfWheels = 3,
                //      ParkingTime = DateTime.Now,
                //      //ChekInTime = DateTime.Now,
                //      CheckOutTime = DateTime.Now,
                //      MemberId = 7893,
                //  },
                //  new ParkedVehicle()
                //  {

                //      RegNr = "0005",
                //      Color = "Green",
                //      Brand = "VOLVO",
                //      Type = "BUSSPower",
                //      NumberOfWheels = 6,
                //      ParkingTime = DateTime.Now,
                //      //ChekInTime = DateTime.Now,
                //      CheckOutTime = DateTime.Now,
                //      MemberId = 7896,

                //  },
                //  new ParkedVehicle()
                //  {

                //      RegNr = "69",
                //      Color = "bronze",
                //      Brand = "VOLVO",
                //      Type = "Family Car",
                //      NumberOfWheels = 4,
                //      ParkingTime = DateTime.Now,
                //      //ChekInTime = DateTime.Now,
                //      CheckOutTime = DateTime.Now,
                //      MemberId = 5623,
                //  });
            });
        }
    }
}

