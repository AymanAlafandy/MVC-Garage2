namespace Garage_WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Memberid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ParkedVehicles", "MemberId", "dbo.Members");
            DropIndex("dbo.ParkedVehicles", new[] { "MemberId" });
            AlterColumn("dbo.ParkedVehicles", "MemberId", c => c.Int(nullable: false));
            CreateIndex("dbo.ParkedVehicles", "MemberId");
            AddForeignKey("dbo.ParkedVehicles", "MemberId", "dbo.Members", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParkedVehicles", "MemberId", "dbo.Members");
            DropIndex("dbo.ParkedVehicles", new[] { "MemberId" });
            AlterColumn("dbo.ParkedVehicles", "MemberId", c => c.Int());
            CreateIndex("dbo.ParkedVehicles", "MemberId");
            AddForeignKey("dbo.ParkedVehicles", "MemberId", "dbo.Members", "Id");
        }
    }
}
