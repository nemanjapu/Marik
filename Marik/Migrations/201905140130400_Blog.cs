namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Blog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Caption = c.String(nullable: false),
                        Text = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ImageName = c.String(),
                        ImagePath = c.String(),
                        UserId = c.Int(nullable: false),
                        Tags = c.String(),
                        MetaDescription = c.String(),
                        MetaKeywords = c.String(),
                        isActive = c.Boolean(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Blogs", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropTable("dbo.Blogs");
        }
    }
}
