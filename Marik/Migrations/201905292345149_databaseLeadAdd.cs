namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databaseLeadAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        PhoneNumber = c.String(),
                        Location = c.String(),
                        BusinessName = c.String(),
                        Website = c.String(),
                        Note = c.String(),
                        LeadSource = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Leads");
        }
    }
}
