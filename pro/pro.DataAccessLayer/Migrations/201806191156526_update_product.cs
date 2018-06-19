namespace pro.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_product : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "Brand_BrandId" });
            RenameColumn(table: "dbo.Products", name: "Brand_BrandId", newName: "BrandId");
            AlterColumn("dbo.Products", "BrandId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "BrandId");
            AddForeignKey("dbo.Products", "BrandId", "dbo.Brands", "BrandId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "BrandId" });
            AlterColumn("dbo.Products", "BrandId", c => c.Int());
            RenameColumn(table: "dbo.Products", name: "BrandId", newName: "Brand_BrandId");
            CreateIndex("dbo.Products", "Brand_BrandId");
            AddForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands", "BrandId");
        }
    }
}
