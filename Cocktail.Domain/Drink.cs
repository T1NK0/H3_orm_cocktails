using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Domain
{
    public class Drink : Parent
    {
        //Adds 3 extra lists to our drink class, but it still inherits from the parent class to have "Id, name, and type"
        //It's in lists as it can have multiple entitys in it.
        private List<Ingredient> _ingredients;
        private List<Accessory> _accessories;
        private List<Alcohol> _alcohols;

        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }

        public List<Accessory> Accessories
        {
            get { return _accessories; }
            set { _accessories = value; }
        }

        public List<Alcohol> Alcohols
        {
            get { return _alcohols; }
            set { _alcohols = value; }
        }

        public Drink()
        {
            Ingredients = new List<Ingredient>();
            Accessories = new List<Accessory>();
            Alcohols = new List<Alcohol>();
        }
    }
}
