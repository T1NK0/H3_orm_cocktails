using Cocktail.Data;
using Cocktail.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static DrinkContext context = new DrinkContext();
        static void Main(string[] args)
        {
            context.Database.EnsureCreated();

            BloodyMarry();
            ScrewDriver();
            TequilaSunrise();

            loadDrinks();
        }

        private static void loadDrinks()
        {
            var drinks = context.Drinks.ToList();
            var alcohols = context.Alcohols.ToList();
            var ingredients = context.Alcohols.ToList();
            var accesories = context.Accessories.ToList();

            foreach (var drink in drinks)
            {
                Console.WriteLine("Drink name: " + drink.Name);
                Console.WriteLine("Drink type: " + drink.Type);

                foreach (var alcohol in drink.Alcohols)
                {
                    Console.WriteLine("Alcohol name: " + alcohol.Name);
                    Console.WriteLine("Alcohol type: " + alcohol.Type);
                }

                foreach (var ingredient in drink.Ingredients)
                {
                    Console.WriteLine("Ingredient name: " + ingredient.Name);
                    Console.WriteLine("Ingredient type:" + ingredient.Type);
                }

                foreach (var accesory in drink.Accessories)
                {
                    Console.WriteLine("Accesory name: " + accesory.Name);
                    Console.WriteLine("Accesory type: " + accesory.Type);
                }
                Console.WriteLine();
            }
        }

        private static void BloodyMarry()
        {
            Drink bloodyMary = new Drink();
            bloodyMary.Name = "Bloody Mary";
            bloodyMary.Type = "Strong Drink";
            bloodyMary.Alcohols.Add(new Alcohol() { Name = "Absolut", Type = "Vodka" });
            bloodyMary.Ingredients.Add(new Ingredient() { Name = "Tomato Juice", Type = "Juice" });
            bloodyMary.Accessories.Add(new Accessory() { Name = "Celleri", Type = "Vegetable" });
            context.Add(bloodyMary);
            context.SaveChanges();
        }
        
        private static void ScrewDriver()
        {
            Drink screwdriver = new Drink();
            screwdriver.Name = "Screwdriver";
            screwdriver.Type = "Strong Drink";
            screwdriver.Alcohols.Add(new Alcohol() { Name = "Smirnoff", Type = "Vodka" });
            screwdriver.Ingredients.Add(new Ingredient() { Name = "Orange Juice", Type = "Juice" });
            screwdriver.Accessories.Add(new Accessory() { });
            context.Add(screwdriver);
            context.SaveChanges();
        }

        private static void TequilaSunrise()
        {
            Drink tequilaSunrise = new Drink();
            tequilaSunrise.Name = "Tequila Sunrise";
            tequilaSunrise.Type = "Strong";
            tequilaSunrise.Alcohols.Add(new Alcohol() { Name = "Tequila ACDC Thunderstruck Blanco", Type = "Tequila" });
            tequilaSunrise.Ingredients.Add(new Ingredient() { Name = "Orange Juice", Type = "Juice" });
            tequilaSunrise.Ingredients.Add(new Ingredient() { Name = "Rød Grenadine", Type = "Colour" });
            tequilaSunrise.Accessories.Add(new Accessory() { Name = "Palm Stick", Type = "Decoration" });
            tequilaSunrise.Accessories.Add(new Accessory() { Name = "Lime Slice", Type = "Flavour" });
            context.Add(tequilaSunrise);
            context.SaveChanges();
        }
    }
}
