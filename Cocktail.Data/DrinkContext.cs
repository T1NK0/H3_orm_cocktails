using Cocktail.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Data
{
    /// <summary>
    /// Here we run our manager on the connection strings and the CRUD's.
    /// </summary>
    public class DrinkContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5432; Database=CocktailData; User Id=postgres; Password=Postgres123!;");
        }

        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Alcohol> Alcohols { get; set; }
        public DbSet<Drink> Drinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drink>()
                .HasMany(d => d.Alcohols);
        }
    }
}
