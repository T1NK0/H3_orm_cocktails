using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Domain.TableJoins
{
    public class DrinkAccessory
    {

        // Creates a class to setup the correct connection between the tables (many to many)
        // as an interstop between the drink and the Accessory.

        private int _drinkId;
        private int _accesoryId;
        private Drink _drink;
        private Accessory _accessory;

        public Accessory Accessory
        {
            get { return _accessory; }
            set { _accessory = value; }
        }

        public Drink Drink
        {
            get { return _drink; }
            set { _drink = value; }
        }

        public int AccessoryId
        {
            get { return _accesoryId; }
            set { _accesoryId = value; }
        }

        public int DrinkId
        {
            get { return _drinkId; }
            set { _drinkId = value; }
        }
    }
}
