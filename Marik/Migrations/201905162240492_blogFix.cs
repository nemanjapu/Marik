namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "UserId", c => c.Int(nullable: false));
        }
    }
}
