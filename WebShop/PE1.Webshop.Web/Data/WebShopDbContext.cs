using Microsoft.EntityFrameworkCore;
using PE1.Webshop.Core.Entities;
using PE1.Webshop.Web.Data.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.Data
{
    public class WebShopDbContext: DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Property> Properties { get; set; }

        public WebShopDbContext(DbContextOptions<WebShopDbContext> options)
            :base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CatergoryId);

            Seeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

    }
}
