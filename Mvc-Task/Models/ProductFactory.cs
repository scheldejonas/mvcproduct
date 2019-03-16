using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Mvc_Task.Models
{
    public class ProductFactory : DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public ProductFactory()
        {
            Database.SetInitializer(new ProductInitializer());
        }
    }

    public class ProductInitializer : DropCreateDatabaseIfModelChanges<ProductFactory>
    {
        protected override void Seed(ProductFactory context)
        {
            context.Products.Add(new Product { Name = "Sour Dough", Color = "Grey", Price = 5 });
            context.Products.Add(new Product { Name = "Full Grain", Color = "Brown", Price = 7.5 });
        }
    }
}