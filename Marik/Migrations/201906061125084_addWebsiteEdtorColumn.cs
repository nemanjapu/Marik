namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addWebsiteEdtorColumn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WebsiteContents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HomepageTitle = c.String(),
                        HomepageSubtitle = c.String(),
                        HomepageMainImageName = c.String(),
                        HomepageMainImagePath = c.String(),
                        HomepageFirstSectionTitle = c.String(),
                        HomepageFirstSectionFirstParagraph = c.String(),
                        HomepageFirstSectionSecondParagraph = c.String(),
                        HomepageFirstSectionImageName = c.String(),
                        HomepageFirstSectionImagePath = c.String(),
                        HomepageServicesTitle = c.String(),
                        HomepageService1ImageName = c.String(),
                        HomepageService1ImagePath = c.String(),
                        HomepageService2ImageName = c.String(),
                        HomepageService2ImagePath = c.String(),
                        HomepageService3ImageName = c.String(),
                        HomepageService3ImagePath = c.String(),
                        HomepageService4ImageName = c.String(),
                        HomepageService4ImagePath = c.String(),
                        HomepageService5ImageName = c.String(),
                        HomepageService5ImagePath = c.String(),
                        HomepageReviewsText = c.String(),
                        HomepageReivewsImageName = c.String(),
                        HomepageReivewsImagePath = c.String(),
                        HomepageSecondSectionTitle = c.String(),
                        HomepageSecondSectionFirstParagraph = c.String(),
                        HomepageSecondSectionSecondParagraph = c.String(),
                        HomepageSecondSectionImageName = c.String(),
                        HomepageSecondSectionImagePath = c.String(),
                        AboutTitle = c.String(),
                        AboutSubtitle = c.String(),
                        AboutMainImageName = c.String(),
                        AboutMainImagePath = c.String(),
                        AboutFirstSectionFirstParagraph = c.String(),
                        AboutFirstSectionSecondParagraph = c.String(),
                        AboutFirstSectionImageName = c.String(),
                        AboutFirstSectionImagePath = c.String(),
                        AboutMyStoryTitle = c.String(),
                        AboutMyStorySubtitle = c.String(),
                        AboutMyStoryContent = c.String(),
                        AboutMyStoryMainImageName = c.String(),
                        AboutMyStoryMainImagePath = c.String(),
                        AboutMyStoryBackgroundImageName = c.String(),
                        AboutMyStoryBackgroundImagePath = c.String(),
                        AboutMyFavoritesTitle = c.String(),
                        AboutMyFavoritesSubtitle = c.String(),
                        AboutMyFavoritesOneOneTitle = c.String(),
                        AboutMyFavoritesOneOneSubtitle = c.String(),
                        AboutMyFavoritesOneTwoTitle = c.String(),
                        AboutMyFavoritesOneTwoSubtitle = c.String(),
                        AboutMyFavoritesTwoOneTitle = c.String(),
                        AboutMyFavoritesTwoOneSubtitle = c.String(),
                        AboutMyFavoritesTwoTwoTitle = c.String(),
                        AboutMyFavoritesTwoTwoSubtitle = c.String(),
                        AboutMyFavoritesThreeOneTitle = c.String(),
                        AboutMyFavoritesThreeOneSubtitle = c.String(),
                        AboutMyFavoritesThreeTwoTitle = c.String(),
                        AboutMyFavoritesThreeTwoSubtitle = c.String(),
                        AboutMyFavoritesMainImageName = c.String(),
                        AboutMyFavoritesMainImagePath = c.String(),
                        AboutMyFavoritesBackgroundImageName = c.String(),
                        AboutMyFavoritesBackgroundImagePath = c.String(),
                        AboutFollowAlongMainImageName = c.String(),
                        AboutFollowAlongMainImagePath = c.String(),
                        ProductsTitle = c.String(),
                        ProductsSubtitle = c.String(),
                        ProductsMainImageName = c.String(),
                        ProductsMainImagePath = c.String(),
                        BlogsTitle = c.String(),
                        BlogsSubtitle = c.String(),
                        BlogsMainImageName = c.String(),
                        BlogsMainImagePath = c.String(),
                        ContactTitle = c.String(),
                        ContactSubtitle = c.String(),
                        ContactMainImageName = c.String(),
                        ContactMainImagePath = c.String(),
                        ContactFirstSectionTitle = c.String(),
                        ContactFirstSectionFirstParagraph = c.String(),
                        ContactFirstSectionSignature = c.String(),
                        FooterImageName = c.String(),
                        FooterImagePath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WebsiteContents");
        }
    }
}
