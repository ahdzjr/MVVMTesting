namespace TestApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddressModels",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        CustomerModel_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.CustomerModels", t => t.CustomerModel_CustomerId)
                .Index(t => t.CustomerModel_CustomerId);
            
            CreateTable(
                "dbo.AppointmentModels",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Job = c.String(),
                        Details = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Vehicle_VehicleId = c.Int(),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.CustomerModels", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.VehicleModels", t => t.Vehicle_VehicleId)
                .Index(t => t.CustomerId)
                .Index(t => t.Vehicle_VehicleId);
            
            CreateTable(
                "dbo.CustomerModels",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress_EmailId = c.Int(),
                        PrimaryAddress_AddressId = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.EmailModels", t => t.EmailAddress_EmailId)
                .ForeignKey("dbo.AddressModels", t => t.PrimaryAddress_AddressId)
                .Index(t => t.EmailAddress_EmailId)
                .Index(t => t.PrimaryAddress_AddressId);
            
            CreateTable(
                "dbo.EmailModels",
                c => new
                    {
                        EmailId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.EmailId);
            
            CreateTable(
                "dbo.VehicleModels",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Make = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleId)
                .ForeignKey("dbo.CustomerModels", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppointmentModels", "Vehicle_VehicleId", "dbo.VehicleModels");
            DropForeignKey("dbo.VehicleModels", "CustomerId", "dbo.CustomerModels");
            DropForeignKey("dbo.CustomerModels", "PrimaryAddress_AddressId", "dbo.AddressModels");
            DropForeignKey("dbo.CustomerModels", "EmailAddress_EmailId", "dbo.EmailModels");
            DropForeignKey("dbo.AppointmentModels", "CustomerId", "dbo.CustomerModels");
            DropForeignKey("dbo.AddressModels", "CustomerModel_CustomerId", "dbo.CustomerModels");
            DropIndex("dbo.VehicleModels", new[] { "CustomerId" });
            DropIndex("dbo.CustomerModels", new[] { "PrimaryAddress_AddressId" });
            DropIndex("dbo.CustomerModels", new[] { "EmailAddress_EmailId" });
            DropIndex("dbo.AppointmentModels", new[] { "Vehicle_VehicleId" });
            DropIndex("dbo.AppointmentModels", new[] { "CustomerId" });
            DropIndex("dbo.AddressModels", new[] { "CustomerModel_CustomerId" });
            DropTable("dbo.VehicleModels");
            DropTable("dbo.EmailModels");
            DropTable("dbo.CustomerModels");
            DropTable("dbo.AppointmentModels");
            DropTable("dbo.AddressModels");
        }
    }
}
