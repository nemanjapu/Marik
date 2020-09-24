namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WebsiteContentAboutFunStuffUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WebsiteContents", "AboutTheFunStuffTitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WebsiteContents", "AboutTheFunStuffTitle");
        }
    }
}
