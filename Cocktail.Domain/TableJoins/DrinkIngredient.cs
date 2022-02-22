using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Domain.TableJoins
{
    public class DrinkIngredient
    {
        // Creates a class to setup the correct connection between the tables (many to many)
        // as an interstop between the drink and the Ingredient.

        private int _drinkId;
        private int _ingredientId;
        private Drink _drink;
        private Ingredient _ingredient;

        public Ingredient Ingredient
        {
            get { return _ingredient; }
            set { _ingredient = value; }
        }

        public Drink Drink
        {
            get { return _drink; }
            set { _drink = value; }
        }

        public int IngredientId
        {
            get { return _ingredientId; }
            set { _ingredientId = value; }
        }

        public int DrinkId
        {
            get { return _drinkId; }
            set { _drinkId = value; }
        }
    }
}
