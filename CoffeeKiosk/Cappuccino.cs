using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeKiosk
{
    internal class Cappuccino : CoffeeBase
    {
        public Cappuccino() 
        {
            coffeeType = CoffeeType.MilkCoffee;
            cupsize = CupSize.Cappuccino;

            isDoubleShot = false;
            addMilk = true;
            addWater = false;
        }
    }
}
