namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGlobalValues : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GlobalValues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                        PhoneNumber1 = c.String(),
                        PhoneNumber2 = c.String(),
                        FacebookLink = c.String(),
                        InstagramLink = c.String(),
                        TwitterLink = c.String(),
                        PinterestLink = c.String(),
                        GooglePlusLink = c.String(),
                        LinkedinLink = c.String(),
                        YoutubeLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GlobalValues");
        }
    }
}
