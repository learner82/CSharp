namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newsletterchanges : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.NewsletterTrues");
            AddColumn("dbo.NewsletterTrues", "Email", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.NewsletterTrues", "Email");
            DropColumn("dbo.NewsletterTrues", "EmailAdress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewsletterTrues", "EmailAdress", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.NewsletterTrues");
            DropColumn("dbo.NewsletterTrues", "Email");
            AddPrimaryKey("dbo.NewsletterTrues", "EmailAdress");
        }
    }
}
