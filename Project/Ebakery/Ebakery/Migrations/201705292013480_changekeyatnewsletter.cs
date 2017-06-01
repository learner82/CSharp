namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changekeyatnewsletter : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.NewsletterTrues");
            AlterColumn("dbo.NewsletterTrues", "EmailAdress", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.NewsletterTrues", "EmailAdress");
            DropColumn("dbo.NewsletterTrues", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewsletterTrues", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.NewsletterTrues");
            AlterColumn("dbo.NewsletterTrues", "EmailAdress", c => c.String());
            AddPrimaryKey("dbo.NewsletterTrues", "Id");
        }
    }
}
