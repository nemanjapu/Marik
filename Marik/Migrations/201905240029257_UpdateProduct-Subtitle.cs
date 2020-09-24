namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductSubtitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Subtitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Subtitle");
        }
    }
}
