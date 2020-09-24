namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNumberOfDownloadsOnProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "NumberOfDownloads", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "NumberOfDownloads");
        }
    }
}
