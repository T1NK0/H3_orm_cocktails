using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Domain.TableJoins
{
    public class DrinkAlcohol
    {

        // Creates a class to setup the correct connection between the tables (many to many)
        // as an interstop between the drink and the Alcohol.

        private int _drinkId;
        private int _alcoholId;
        private Drink _drink;
        private Alcohol _alcohol;

        public Alcohol Alcohol
        {
            get { return _alcohol; }
            set { _alcohol = value; }
        }


        public Drink Drink
        {
            get { return _drink; }
            set { _drink = value; }
        }


        public int AlcoholId
        {
            get { return _alcoholId; }
            set { _alcoholId = value; }
        }


        public int DrinkId
        {
            get { return _drinkId; }
            set { _drinkId = value; }
        }

    }
}
