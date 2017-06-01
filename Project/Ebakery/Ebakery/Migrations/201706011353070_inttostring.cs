namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inttostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "StreetNumber", c => c.String());
            AlterColumn("dbo.Users", "ZipCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "ZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "StreetNumber", c => c.Int(nullable: false));
        }
    }
}
