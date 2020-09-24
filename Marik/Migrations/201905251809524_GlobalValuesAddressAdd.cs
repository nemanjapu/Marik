namespace Marik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GlobalValuesAddressAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GlobalValues", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.GlobalValues", "Address");
        }
    }
}
