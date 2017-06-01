namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isadminfalse : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "IsAdmin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "IsAdmin", c => c.Boolean(nullable: false));
        }
    }
}
