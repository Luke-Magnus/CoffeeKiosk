using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeKiosk
{
    public abstract class CoffeeBase
    {
        public CoffeeType coffeeType;
        public CupSize cupsize;

        public bool isDoubleShot;
        public bool addMilk;
        public bool addWater;

        public virtual void PourCoffee(bool useDecafBeans)
        {
            if(useDecafBeans)
                MessageBox.Show("Grinding Decaf Beans.");
            else
                MessageBox.Show("Grinding Coffee Beans.");
            
            MessageBox.Show($"Place {cupsize} container under spout.");

            if (isDoubleShot)
                MessageBox.Show("Pouring Coffee Double Shot.");
            else
                MessageBox.Show("Pouring Coffee Shot.");

            if(addMilk)
                MessageBox.Show("Adding Milk.");

            if(addWater)
                MessageBox.Show("Adding Water.");

            MessageBox.Show("Coffee Complete.");
        }
    }

    public enum CupSize
    {
        Espresso, Cappuccino, SmallGlass, LargeGlass, Mug
    }

    public enum CoffeeType
    {
        BlackCoffee, MilkCoffee
    }

    /*
     single espresso
        single shot, no milk, no water, Espresso
    double espresso
        double shot, no milk, no water, cappuccino
    americano
        single shot, no milk, add water, cappuccino
    black coffee
        double shot, no milk, add water, cappuccino (water can provided separately)

    cappuccino
        single shot, foam milk, no water, cappuccino cup
    espresso Macchiato
        single shot, foam milk, no water, Espresso
    cortado
        single shot, foam milk, no water, small glass
    Flat White
        double shot, foam milk, no water, large glass
    Caffe Latte
        single shot, foam milk, no water, mug
     */
}
