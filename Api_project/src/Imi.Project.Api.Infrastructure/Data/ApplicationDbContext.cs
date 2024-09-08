using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Infrastructure.Data.Seeding;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public DbSet<Fish> Fishs { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<OriginCountry> OriginCountries { get; set; }

        public DbSet<FishProcessing> FishProcessings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
          base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Fish>().Property(f => f.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Category>().Property(f => f.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<FishProcessing>().Property(f => f.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<OriginCountry>().Property(f => f.Name).HasMaxLength(100).IsRequired();

            Seeder.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);

        }

    }
}
