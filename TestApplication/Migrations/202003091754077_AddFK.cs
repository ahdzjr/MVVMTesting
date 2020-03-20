namespace TestApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AppointmentModels", "CustomerId", "dbo.CustomerModels");
            AddColumn("dbo.AppointmentModels", "Customer_CustomerId", c => c.Int());
            AddColumn("dbo.AppointmentModels", "CustomerModel_CustomerId", c => c.Int());
            CreateIndex("dbo.AddressModels", "CustomerId");
            CreateIndex("dbo.AppointmentModels", "Customer_CustomerId");
            CreateIndex("dbo.AppointmentModels", "CustomerModel_CustomerId");
            AddForeignKey("dbo.AppointmentModels", "CustomerId", "dbo.CustomerModels", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.AddressModels", "CustomerId", "dbo.CustomerModels", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.AppointmentModels", "Customer_CustomerId", "dbo.CustomerModels", "CustomerId");
            AddForeignKey("dbo.AppointmentModels", "CustomerModel_CustomerId", "dbo.CustomerModels", "CustomerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppointmentModels", "CustomerModel_CustomerId", "dbo.CustomerModels");
            DropForeignKey("dbo.AppointmentModels", "Customer_CustomerId", "dbo.CustomerModels");
            DropForeignKey("dbo.AddressModels", "CustomerId", "dbo.CustomerModels");
            DropForeignKey("dbo.AppointmentModels", "CustomerId", "dbo.CustomerModels");
            DropIndex("dbo.AppointmentModels", new[] { "CustomerModel_CustomerId" });
            DropIndex("dbo.AppointmentModels", new[] { "Customer_CustomerId" });
            DropIndex("dbo.AddressModels", new[] { "CustomerId" });
            DropColumn("dbo.AppointmentModels", "CustomerModel_CustomerId");
            DropColumn("dbo.AppointmentModels", "Customer_CustomerId");
            AddForeignKey("dbo.AppointmentModels", "CustomerId", "dbo.CustomerModels", "CustomerId", cascadeDelete: true);
        }
    }
}
