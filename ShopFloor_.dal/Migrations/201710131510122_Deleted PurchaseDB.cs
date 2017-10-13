namespace ShopFloor_.dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedPurchaseDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductDBModels", "PurchaseDBModel_Id", "dbo.PurchaseDBModels");
            DropForeignKey("dbo.PurchaseDBModels", "User_Id", "dbo.UserDBModels");
            DropIndex("dbo.ProductDBModels", new[] { "PurchaseDBModel_Id" });
            DropIndex("dbo.PurchaseDBModels", new[] { "User_Id" });
            DropColumn("dbo.ProductDBModels", "PurchaseDBModel_Id");
            DropTable("dbo.PurchaseDBModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PurchaseDBModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ProductDBModels", "PurchaseDBModel_Id", c => c.Int());
            CreateIndex("dbo.PurchaseDBModels", "User_Id");
            CreateIndex("dbo.ProductDBModels", "PurchaseDBModel_Id");
            AddForeignKey("dbo.PurchaseDBModels", "User_Id", "dbo.UserDBModels", "Id");
            AddForeignKey("dbo.ProductDBModels", "PurchaseDBModel_Id", "dbo.PurchaseDBModels", "Id");
        }
    }
}
