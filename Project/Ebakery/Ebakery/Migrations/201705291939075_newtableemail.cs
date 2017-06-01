namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtableemail : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "NewsLetter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "NewsLetter", c => c.Boolean(nullable: false));
        }
    }
}
