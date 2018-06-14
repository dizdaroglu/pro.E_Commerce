namespace pro.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createAllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        BasketId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RemovedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BasketId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        ProfileImage = c.String(),
                        RoleId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RemovedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Favs",
                c => new
                    {
                        FavId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RemovedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FavId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductCode = c.Guid(nullable: false),
                        UnitsInStock = c.Double(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        SubCategoryId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RemovedDate = c.DateTime(nullable: false),
                        Category_CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .Index(t => t.SubCategoryId)
                .Index(t => t.Category_CategoryId);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        ColorId = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RemovedDate = c.DateTime(nullable: false),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.ColorId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImagesId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.ImagesId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        SizeId = c.Int(nullable: false, identity: true),
                        Sizes = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RemovedDate = c.DateTime(nullable: false),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.SizeId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        SubCategoryId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RemovedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SubCategoryId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RemovedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RemovedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Buys",
                c => new
                    {
                        BuyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        CompanyName = c.Int(nullable: false),
                        Country = c.String(),
                        Address = c.String(),
                        PostCode = c.Int(nullable: false),
                        City = c.String(),
                        Province = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        PrductId = c.Int(nullable: false),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.BuyId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.ProductSizeColors",
                c => new
                    {
                        ProductSizeColorId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ColorId = c.Int(nullable: false),
                        SizeId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RemovedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductSizeColorId)
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sizes", t => t.SizeId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ColorId)
                .Index(t => t.SizeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductSizeColors", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.ProductSizeColors", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductSizeColors", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Buys", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Baskets", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Baskets", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Favs", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Sizes", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Colors", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Favs", "CustomerId", "dbo.Customers");
            DropIndex("dbo.ProductSizeColors", new[] { "SizeId" });
            DropIndex("dbo.ProductSizeColors", new[] { "ColorId" });
            DropIndex("dbo.ProductSizeColors", new[] { "ProductId" });
            DropIndex("dbo.Buys", new[] { "Product_ProductId" });
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropIndex("dbo.Sizes", new[] { "Product_ProductId" });
            DropIndex("dbo.Images", new[] { "ProductId" });
            DropIndex("dbo.Colors", new[] { "Product_ProductId" });
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            DropIndex("dbo.Products", new[] { "SubCategoryId" });
            DropIndex("dbo.Favs", new[] { "ProductId" });
            DropIndex("dbo.Favs", new[] { "CustomerId" });
            DropIndex("dbo.Customers", new[] { "RoleId" });
            DropIndex("dbo.Baskets", new[] { "ProductId" });
            DropIndex("dbo.Baskets", new[] { "CustomerId" });
            DropTable("dbo.ProductSizeColors");
            DropTable("dbo.Buys");
            DropTable("dbo.Roles");
            DropTable("dbo.Categories");
            DropTable("dbo.SubCategories");
            DropTable("dbo.Sizes");
            DropTable("dbo.Images");
            DropTable("dbo.Colors");
            DropTable("dbo.Products");
            DropTable("dbo.Favs");
            DropTable("dbo.Customers");
            DropTable("dbo.Baskets");
        }
    }
}
