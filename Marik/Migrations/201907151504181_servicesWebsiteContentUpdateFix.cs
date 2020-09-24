namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class servicesWebsiteContentUpdateFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WebsiteContents", "ServiceContentManagementTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceContentManagementSubtitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceContentManagementMainImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceContentManagementMainImagePath", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceContentManagementFirstSectionTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceContentManagementFirstSectionFirstParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceContentManagementFirstSectionSecondParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceContentManagementFirstSectionImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceContentManagementFirstSectionImagePath", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceWebDesignTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceWebDesignSubtitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceWebDesignMainImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceWebDesignMainImagePath", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceWebDesignFirstSectionTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceWebDesignFirstSectionFirstParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceWebDesignFirstSectionSecondParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceWebDesignFirstSectionImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceWebDesignFirstSectionImagePath", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceSPSSTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceSPSSSubtitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceSPSSMainImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceSPSSMainImagePath", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceSPSSFirstSectionTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceSPSSFirstSectionFirstParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceSPSSFirstSectionSecondParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceSPSSFirstSectionImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceSPSSFirstSectionImagePath", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceMarketingTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceMarketingSubtitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceMarketingMainImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceMarketingMainImagePath", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceMarketingFirstSectionTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceMarketingFirstSectionFirstParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceMarketingFirstSectionSecondParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceMarketingFirstSectionImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceMarketingFirstSectionImagePath", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceGraphicDesignTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceGraphicDesignSubtitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceGraphicDesignMainImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceGraphicDesignMainImagePath", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceGraphicDesignFirstSectionTitle", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceGraphicDesignFirstSectionFirstParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceGraphicDesignFirstSectionSecondParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceGraphicDesignFirstSectionImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceGraphicDesignFirstSectionImagePath", c => c.String());
            DropColumn("dbo.WebsiteContents", "ServiceFirstSectionTitle");
            DropColumn("dbo.WebsiteContents", "ServiceFirstSectionFirstParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceFirstSectionSecondParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceFirstSectionImageName");
            DropColumn("dbo.WebsiteContents", "ServiceFirstSectionImagePath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WebsiteContents", "ServiceFirstSectionImagePath", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceFirstSectionImageName", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceFirstSectionSecondParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceFirstSectionFirstParagraph", c => c.String());
            AddColumn("dbo.WebsiteContents", "ServiceFirstSectionTitle", c => c.String());
            DropColumn("dbo.WebsiteContents", "ServiceGraphicDesignFirstSectionImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceGraphicDesignFirstSectionImageName");
            DropColumn("dbo.WebsiteContents", "ServiceGraphicDesignFirstSectionSecondParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceGraphicDesignFirstSectionFirstParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceGraphicDesignFirstSectionTitle");
            DropColumn("dbo.WebsiteContents", "ServiceGraphicDesignMainImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceGraphicDesignMainImageName");
            DropColumn("dbo.WebsiteContents", "ServiceGraphicDesignSubtitle");
            DropColumn("dbo.WebsiteContents", "ServiceGraphicDesignTitle");
            DropColumn("dbo.WebsiteContents", "ServiceMarketingFirstSectionImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceMarketingFirstSectionImageName");
            DropColumn("dbo.WebsiteContents", "ServiceMarketingFirstSectionSecondParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceMarketingFirstSectionFirstParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceMarketingFirstSectionTitle");
            DropColumn("dbo.WebsiteContents", "ServiceMarketingMainImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceMarketingMainImageName");
            DropColumn("dbo.WebsiteContents", "ServiceMarketingSubtitle");
            DropColumn("dbo.WebsiteContents", "ServiceMarketingTitle");
            DropColumn("dbo.WebsiteContents", "ServiceSPSSFirstSectionImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceSPSSFirstSectionImageName");
            DropColumn("dbo.WebsiteContents", "ServiceSPSSFirstSectionSecondParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceSPSSFirstSectionFirstParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceSPSSFirstSectionTitle");
            DropColumn("dbo.WebsiteContents", "ServiceSPSSMainImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceSPSSMainImageName");
            DropColumn("dbo.WebsiteContents", "ServiceSPSSSubtitle");
            DropColumn("dbo.WebsiteContents", "ServiceSPSSTitle");
            DropColumn("dbo.WebsiteContents", "ServiceWebDesignFirstSectionImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceWebDesignFirstSectionImageName");
            DropColumn("dbo.WebsiteContents", "ServiceWebDesignFirstSectionSecondParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceWebDesignFirstSectionFirstParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceWebDesignFirstSectionTitle");
            DropColumn("dbo.WebsiteContents", "ServiceWebDesignMainImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceWebDesignMainImageName");
            DropColumn("dbo.WebsiteContents", "ServiceWebDesignSubtitle");
            DropColumn("dbo.WebsiteContents", "ServiceWebDesignTitle");
            DropColumn("dbo.WebsiteContents", "ServiceContentManagementFirstSectionImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceContentManagementFirstSectionImageName");
            DropColumn("dbo.WebsiteContents", "ServiceContentManagementFirstSectionSecondParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceContentManagementFirstSectionFirstParagraph");
            DropColumn("dbo.WebsiteContents", "ServiceContentManagementFirstSectionTitle");
            DropColumn("dbo.WebsiteContents", "ServiceContentManagementMainImagePath");
            DropColumn("dbo.WebsiteContents", "ServiceContentManagementMainImageName");
            DropColumn("dbo.WebsiteContents", "ServiceContentManagementSubtitle");
            DropColumn("dbo.WebsiteContents", "ServiceContentManagementTitle");
        }
    }
}
