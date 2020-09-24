namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReviewsModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClientReviews", "isActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClientReviews", "isActive", c => c.String());
        }
    }
}
