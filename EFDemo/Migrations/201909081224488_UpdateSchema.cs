namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSchema : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "testQty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "testQty", c => c.Int(nullable: false));
        }
    }
}
