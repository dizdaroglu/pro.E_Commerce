namespace pro.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_brand_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RemovedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BrandId);
            
            AddColumn("dbo.Products", "Brand_BrandId", c => c.Int());
            CreateIndex("dbo.Products", "Brand_BrandId");
            AddForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands", "BrandId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "Brand_BrandId" });
            DropColumn("dbo.Products", "Brand_BrandId");
            DropTable("dbo.Brands");
        }
    }
}
