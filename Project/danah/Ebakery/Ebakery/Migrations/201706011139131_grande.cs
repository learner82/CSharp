namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class grande : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coupons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Surname = c.String(maxLength: 100),
                        Telephone = c.String(nullable: false),
                        StreetName = c.String(maxLength: 100),
                        StreetNumber = c.Int(nullable: false),
                        ZipCode = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        IsSubmitedToNewsLetter = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HasDiscount = c.Boolean(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        BasketId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Baskets", t => t.BasketId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.BasketId);
            
            CreateTable(
                "dbo.ProductBaskets",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Basket_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Basket_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Baskets", t => t.Basket_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Basket_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Users");
            DropForeignKey("dbo.Orders", "BasketId", "dbo.Baskets");
            DropForeignKey("dbo.Coupons", "UserId", "dbo.Users");
            DropForeignKey("dbo.ProductBaskets", "Basket_Id", "dbo.Baskets");
            DropForeignKey("dbo.ProductBaskets", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductBaskets", new[] { "Basket_Id" });
            DropIndex("dbo.ProductBaskets", new[] { "Product_Id" });
            DropIndex("dbo.Orders", new[] { "BasketId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Coupons", new[] { "UserId" });
            DropTable("dbo.ProductBaskets");
            DropTable("dbo.Orders");
            DropTable("dbo.Users");
            DropTable("dbo.Coupons");
            DropTable("dbo.Products");
            DropTable("dbo.Baskets");
        }
    }
}
