using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class MediumPizza : Pizza
    {
        public MediumPizza() : base("medium") { }


        public override void ViewPizza()
        {
            foreach (string topping in Toppings)
            {
                Console.WriteLine($"-{topping}");
            }
        }

        public override int GetPrice()
        {
            return 12 + 2 * Toppings.Count;
        }
    }
}
