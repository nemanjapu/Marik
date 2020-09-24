namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductFileAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "DocumentName", c => c.String());
            AddColumn("dbo.Products", "DocumentPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "DocumentPath");
            DropColumn("dbo.Products", "DocumentName");
        }
    }
}
