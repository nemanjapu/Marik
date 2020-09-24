namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WebsiteContentAboutTitleUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WebsiteContents", "AboutFirstSectionTitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WebsiteContents", "AboutFirstSectionTitle");
        }
    }
}
