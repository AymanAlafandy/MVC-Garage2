namespace Garage_WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ViclesMigAy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParkedVehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        RegistrationNumber = c.Int(nullable: false),
                        Color = c.String(),
                        Brand = c.String(),
                        Model = c.String(),
                        NumberOfWheels = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ParkedVehicles");
        }
    }
}
