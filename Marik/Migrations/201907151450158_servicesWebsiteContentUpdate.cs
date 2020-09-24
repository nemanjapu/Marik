namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class servicesWebsiteContentUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WebsiteContents", "ServiceTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceSubtitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceMainImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceMainImagePath", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceFirstSectionTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceFirstSectionFirstParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceFirstSectionSecondParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceFirstSectionImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceFirstSectionImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WebsiteContents", "ServiceFirstSectionImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceFirstSectionImageName");
            DropColumn("dbo.WebsiteContents", "ServiceFirstSectionSecondParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceFirstSectionFirstParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceFirstSectionTitle");
            DropColumn("dbo.WebsiteContents", "ServiceMainImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceMainImageName");
            DropColumn("dbo.WebsiteContents", "ServiceSubtitle");
            DropColumn("dbo.WebsiteContents", "ServiceTitle");
        }
    }
}
