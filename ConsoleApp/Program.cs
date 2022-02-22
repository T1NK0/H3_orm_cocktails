using Cocktail.Data;
using Cocktail.Domain;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static DrinkContext context = new DrinkContext();
        static void Main(string[] args)
        {
            context.Database.EnsureCreated();

            var drinks = context.Drinks.ToList();
            var alcohol = context.Alcohols.ToList();
            var ingredient = context.Alcohols.ToList();
            var accesories = context.Accessories.ToList();

            Drink bloodyMary = new Drink();
            bloodyMary.Name = "Bloody Mary";
            bloodyMary.Type = "Strong Drink";
            bloodyMary.Alcohols.Add(new Alcohol() { Name = "Absolut", Type = "Vodka" });
            bloodyMary.Ingredients.Add(new Ingredient() { Name = "Tomato Juice", Type = "Juice" });
            bloodyMary.Accessories.Add(new Accessory() { Name = "Celleri", Type = "Vegetable" });
            context.Add(bloodyMary);
            context.SaveChanges();

            Drink screwdriver = new Drink();
            screwdriver.Name = "Screwdriver";
            screwdriver.Type = "Strong Drink";
            screwdriver.Alcohols.Add(new Alcohol() { Name = "Smirnoff", Type = "Vodka" });
            screwdriver.Ingredients.Add(new Ingredient() { Name = "Orange Juice", Type = "Juice" });
            screwdriver.Accessories.Add(new Accessory() {});
            context.Add(screwdriver);
            context.SaveChanges();

            Drink tequilaSunrise = new Drink();
            tequilaSunrise.Name = "Tequila Sunrise";
            tequilaSunrise.Type = "Strong";
            tequilaSunrise.Alcohols.Add(new Alcohol() { Name = "Tequila ACDC Thunderstruck Blanco", Type = "Tequila" });
            tequilaSunrise.Ingredients.Add(new Ingredient() { Name = "Orange Juice", Type = "Juice"});
            tequilaSunrise.Ingredients.Add(new Ingredient() { Name = "Rød Grenadine", Type = "Colour" });
            tequilaSunrise.Accessories.Add(new Accessory() { Name = "Palm Stick", Type = "Decoration" });
            tequilaSunrise.Accessories.Add(new Accessory() { Name = "Lime Slice", Type = "Flavour" });
            context.Add(tequilaSunrise);
            context.SaveChanges();

            Console.WriteLine("Hello World!");
        }
    }
}
