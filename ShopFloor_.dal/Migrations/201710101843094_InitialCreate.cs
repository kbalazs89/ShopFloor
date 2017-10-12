namespace ShopFloor_.dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDBModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Cathegory = c.String(),
                        NrOfSeats = c.Int(nullable: false),
                        FlightRange = c.Int(nullable: false),
                        NrOfEngines = c.Int(nullable: false),
                        PurchaseDBModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PurchaseDBModels", t => t.PurchaseDBModel_Id)
                .Index(t => t.PurchaseDBModel_Id);
            
            CreateTable(
                "dbo.PurchaseDBModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserDBModels", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserDBModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Cash = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseDBModels", "User_Id", "dbo.UserDBModels");
            DropForeignKey("dbo.ProductDBModels", "PurchaseDBModel_Id", "dbo.PurchaseDBModels");
            DropIndex("dbo.PurchaseDBModels", new[] { "User_Id" });
            DropIndex("dbo.ProductDBModels", new[] { "PurchaseDBModel_Id" });
            DropTable("dbo.UserDBModels");
            DropTable("dbo.PurchaseDBModels");
            DropTable("dbo.ProductDBModels");
        }
    }
}
