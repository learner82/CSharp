namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedforeingkeysfromuser : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "OrderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "OrderId", c => c.Int(nullable: false));
        }
    }
}
