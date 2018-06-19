namespace pro.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_customer_activecode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "ActivationCode", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "ActivationCode");
            DropColumn("dbo.Customers", "isActive");
        }
    }
}
