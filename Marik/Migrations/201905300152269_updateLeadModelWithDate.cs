namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateLeadModelWithDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Leads", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Leads", "Date");
        }
    }
}
