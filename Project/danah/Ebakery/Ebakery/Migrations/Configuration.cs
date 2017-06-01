namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Ebakery.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Ebakery.Models.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ebakery.Models.MyContext context)
        {
            context.Products.AddOrUpdate(
                x => x.Name,
                new Product {Name = "Nes", Price = 4, Category = "Coffee"}
                );

            context.SaveChanges();
        }
    }
}
