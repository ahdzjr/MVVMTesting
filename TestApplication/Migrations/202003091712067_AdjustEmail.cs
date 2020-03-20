namespace TestApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustEmail : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerModels", "EmailAddress_EmailId", "dbo.EmailModels");
            DropIndex("dbo.CustomerModels", new[] { "EmailAddress_EmailId" });
            AddColumn("dbo.CustomerModels", "EmailAddress", c => c.String());
            DropColumn("dbo.CustomerModels", "EmailAddress_EmailId");
            DropTable("dbo.EmailModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmailModels",
                c => new
                    {
                        EmailId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.EmailId);
            
            AddColumn("dbo.CustomerModels", "EmailAddress_EmailId", c => c.Int());
            DropColumn("dbo.CustomerModels", "EmailAddress");
            CreateIndex("dbo.CustomerModels", "EmailAddress_EmailId");
            AddForeignKey("dbo.CustomerModels", "EmailAddress_EmailId", "dbo.EmailModels", "EmailId");
        }
    }
}
