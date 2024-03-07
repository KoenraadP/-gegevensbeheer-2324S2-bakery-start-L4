namespace Bakery.Dal.Migrations
{
    using Bakery.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Bakery.Dal.BakeryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Bakery.Dal.BakeryDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // twee test categorieën maken
            Category c1 = new Category("Brood");
            Category c2 = new Category("Gebak");

            // categorieën Brood en Gebak toevoegen aan
            // tabel Categories in databank
            context.Categories.AddOrUpdate(c1, c2);

            // twee test producten maken 
            Product p1 = new Product("Eclair");
            Product p2 = new Product("Groot bruin brood",
                "Brood...dat groot en bruin is", "brownbread.jpg",
                2.3M, true, c1);

            // producten Eclair en Groot bruin brood
            // toevoegen aan tabel Products in databank
            context.Products.AddOrUpdate(p1, p2);
        }
    }
}
