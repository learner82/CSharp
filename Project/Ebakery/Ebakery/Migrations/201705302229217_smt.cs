namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsAdmin", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Users", "Telephone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Telephone", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "IsAdmin");
        }
    }
}
