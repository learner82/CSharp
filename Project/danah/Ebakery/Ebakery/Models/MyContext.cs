namespace Ebakery.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyContext : DbContext
    {
        // Your context has been configured to use a 'MyContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Ebakery.Models.MyContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyContext' 
        // connection string in the application configuration file.
        public MyContext()
            : base("name=MyContext")
        {
         //   Database.SetInitializer<DbContext>(new CreateDatabaseIfNotExists<DbContext>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.


        public  DbSet<Coupon> Coupons { get; set; }
        public  DbSet<Order> Orders { get; set; }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<User> Users { get; set; }
        public  DbSet<Basket> Baskets { get; set; }



        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}