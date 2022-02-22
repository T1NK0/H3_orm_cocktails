using Cocktail.Domain;
using Cocktail.Domain.TableJoins;
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


        //Here we create our "DbSet's" which contains the results from our queries in to the database, that we then can call in our program file.
        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Alcohol> Alcohols { get; set; }
        public DbSet<Drink> Drinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Says that our DrinkAccessory has the key (DA for DrinkAccessory) and says it's a new key, then binds to the DA's drink id and accessory id.
            modelBuilder.Entity<DrinkAccessory>().HasKey(da => new {da.DrinkId, da.AccessoryId });
            modelBuilder.Entity<DrinkAlcohol>().HasKey(da => new { da.DrinkId, da.AlcoholId });
            modelBuilder.Entity<DrinkIngredient>().HasKey(di => new { di.DrinkId, di.IngredientId });
        }
    }
}
