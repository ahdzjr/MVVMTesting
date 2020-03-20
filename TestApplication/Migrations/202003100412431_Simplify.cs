namespace TestApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Simplify : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AddressModels", "CustomerModel_CustomerId", "dbo.CustomerModels");
            DropForeignKey("dbo.AppointmentModels", "Customer_CustomerId", "dbo.CustomerModels");
            DropForeignKey("dbo.AppointmentModels", "CustomerId", "dbo.CustomerModels");
            DropForeignKey("dbo.VehicleModels", "CustomerId", "dbo.CustomerModels");
            DropForeignKey("dbo.AppointmentModels", "Vehicle_VehicleId", "dbo.VehicleModels");
            DropForeignKey("dbo.AppointmentModels", "CustomerModel_CustomerId", "dbo.CustomerModels");
            DropForeignKey("dbo.CustomerModels", "PrimaryAddress_AddressId", "dbo.AddressModels");
            DropForeignKey("dbo.AddressModels", "CustomerId", "dbo.CustomerModels");
            DropIndex("dbo.AddressModels", new[] { "CustomerId" });
            DropIndex("dbo.AddressModels", new[] { "CustomerModel_CustomerId" });
            DropIndex("dbo.CustomerModels", new[] { "PrimaryAddress_AddressId" });
            DropIndex("dbo.AppointmentModels", new[] { "CustomerId" });
            DropIndex("dbo.AppointmentModels", new[] { "Customer_CustomerId" });
            DropIndex("dbo.AppointmentModels", new[] { "Vehicle_VehicleId" });
            DropIndex("dbo.AppointmentModels", new[] { "CustomerModel_CustomerId" });
            DropIndex("dbo.VehicleModels", new[] { "CustomerId" });
            AlterColumn("dbo.AppointmentModels", "Details", c => c.String(maxLength: 250));
            DropColumn("dbo.AddressModels", "CustomerId");
            DropColumn("dbo.AddressModels", "CustomerModel_CustomerId");
            DropColumn("dbo.CustomerModels", "PrimaryAddress_AddressId");
            DropColumn("dbo.AppointmentModels", "CustomerId");
            DropColumn("dbo.AppointmentModels", "Customer_CustomerId");
            DropColumn("dbo.AppointmentModels", "Vehicle_VehicleId");
            DropColumn("dbo.AppointmentModels", "CustomerModel_CustomerId");
            DropColumn("dbo.VehicleModels", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VehicleModels", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.AppointmentModels", "CustomerModel_CustomerId", c => c.Int());
            AddColumn("dbo.AppointmentModels", "Vehicle_VehicleId", c => c.Int());
            AddColumn("dbo.AppointmentModels", "Customer_CustomerId", c => c.Int());
            AddColumn("dbo.AppointmentModels", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.CustomerModels", "PrimaryAddress_AddressId", c => c.Int());
            AddColumn("dbo.AddressModels", "CustomerModel_CustomerId", c => c.Int());
            AddColumn("dbo.AddressModels", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.AppointmentModels", "Details", c => c.String());
            CreateIndex("dbo.VehicleModels", "CustomerId");
            CreateIndex("dbo.AppointmentModels", "CustomerModel_CustomerId");
            CreateIndex("dbo.AppointmentModels", "Vehicle_VehicleId");
            CreateIndex("dbo.AppointmentModels", "Customer_CustomerId");
            CreateIndex("dbo.AppointmentModels", "CustomerId");
            CreateIndex("dbo.CustomerModels", "PrimaryAddress_AddressId");
            CreateIndex("dbo.AddressModels", "CustomerModel_CustomerId");
            CreateIndex("dbo.AddressModels", "CustomerId");
            AddForeignKey("dbo.AddressModels", "CustomerId", "dbo.CustomerModels", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.CustomerModels", "PrimaryAddress_AddressId", "dbo.AddressModels", "AddressId");
            AddForeignKey("dbo.AppointmentModels", "CustomerModel_CustomerId", "dbo.CustomerModels", "CustomerId");
            AddForeignKey("dbo.AppointmentModels", "Vehicle_VehicleId", "dbo.VehicleModels", "VehicleId");
            AddForeignKey("dbo.VehicleModels", "CustomerId", "dbo.CustomerModels", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.AppointmentModels", "CustomerId", "dbo.CustomerModels", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.AppointmentModels", "Customer_CustomerId", "dbo.CustomerModels", "CustomerId");
            AddForeignKey("dbo.AddressModels", "CustomerModel_CustomerId", "dbo.CustomerModels", "CustomerId");
        }
    }
}
