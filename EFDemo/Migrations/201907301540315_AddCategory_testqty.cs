namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory_testqty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "testQty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "testQty");
        }
    }
}
