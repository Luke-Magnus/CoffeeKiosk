using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeKiosk
{
    internal class Latte : CoffeeBase
    {
        public Latte()
        {
            coffeeType = CoffeeType.MilkCoffee;
            cupsize = CupSize.Mug;

            isDoubleShot = false;
            addMilk = true;
            addWater = false;
        }
    }
}
