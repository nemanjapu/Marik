namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductAndProductImages : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        Extension = c.String(),
                        ProductId = c.Int(nullable: false),
                        SortOrder = c.Int(nullable: false),
                        FileNameNoExt = c.String(),
                        FilePath = c.String(),
                        NumberOfDownloads = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Text = c.String(),
                        DatePublished = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MetaKeywords = c.String(),
                        MetaDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductImages", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductImages", new[] { "ProductId" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductImages");
        }
    }
}
