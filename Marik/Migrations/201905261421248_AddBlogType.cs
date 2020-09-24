namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Blogs", "BlogTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Blogs", "BlogTypeId");
            AddForeignKey("dbo.Blogs", "BlogTypeId", "dbo.BlogTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "BlogTypeId", "dbo.BlogTypes");
            DropIndex("dbo.Blogs", new[] { "BlogTypeId" });
            DropColumn("dbo.Blogs", "BlogTypeId");
            DropTable("dbo.BlogTypes");
        }
    }
}
