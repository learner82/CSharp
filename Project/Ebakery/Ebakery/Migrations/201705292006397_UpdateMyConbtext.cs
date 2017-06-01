namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMyConbtext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewsletterTrues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailAdress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewsletterTrues");
        }
    }
}
