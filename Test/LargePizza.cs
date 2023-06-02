using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class LargePizza : Pizza
    {
        public LargePizza() : base("Small") { }


        public override void ViewPizza()
        {
            foreach (string topping in Toppings)
            {
                Console.WriteLine($"-{topping}");
            }
        }

        public override int GetPrice()
        {
            return 14 + 2 * Toppings.Count;
        }
    }
}
