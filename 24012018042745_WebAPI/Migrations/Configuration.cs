namespace _24012018042745_WebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using _24012018042745_WebAPI.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<_24012018042745_WebAPI.Models.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_24012018042745_WebAPI.Models.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Products.AddOrUpdate(x=>x.ProductId,
                new Product() {
                    ProductId = 1,
                    ProductName = "Extending Bootstrap with CSSJavaScript and jQuery",
                    IntroductionDate = Convert.ToDateTime("06/29/2017"),
                    Url = "http://bit.ly/1SNzc0i"
                },
                new Product() {
                    ProductId = 2,
                    ProductName = "Build your own Bootstrap BusinessApplication Template in MVC",
                    IntroductionDate = Convert.ToDateTime("1/31/2017"),
                    Url = "http://bit.ly/1I8ZqZg"
                },
                new Product() {
                    ProductId = 3,
                    ProductName = "Building Mobile Web Sites Using Web Forms Bootstrapand HTML5",
                    IntroductionDate = Convert.ToDateTime("8/2/2017"),
                    Url = "http://bit.ly/1J2dcrj"
                });
        }
    }
}
