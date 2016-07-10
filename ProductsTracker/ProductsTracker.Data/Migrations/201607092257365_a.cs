namespace ProductsTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Store",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SearchURL = c.String(),
                        Regex = c.String(),
                        ProductRegexGroupName = c.String(),
                        ProductURLRegexGroupName = c.String(),
                        PriceRegexGroupName = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Product_ProductID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.Product_ProductID)
                .Index(t => t.Product_ProductID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Manifacturer = c.String(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        UserID = c.Int(nullable: false),
                        Store_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Store", t => t.Store_ID)
                .Index(t => t.UserID)
                .Index(t => t.Store_ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Store_ID", "dbo.Store");
            DropForeignKey("dbo.Product", "UserID", "dbo.User");
            DropForeignKey("dbo.Store", "Product_ProductID", "dbo.Product");
            DropIndex("dbo.Product", new[] { "Store_ID" });
            DropIndex("dbo.Product", new[] { "UserID" });
            DropIndex("dbo.Store", new[] { "Product_ProductID" });
            DropTable("dbo.User");
            DropTable("dbo.Product");
            DropTable("dbo.Store");
        }
    }
}
