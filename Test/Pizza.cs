using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test
{
    abstract class Pizza
    {
        public string Size { get; set; }
        public List<string> Toppings { get; }

      public Pizza(string Size)
        {
            this.Size = Size;
            Toppings = new List<string>();
        }

      public void PizzaToppings(string topping) { Toppings.Add(topping); }

        public abstract void ViewPizza();
        public abstract int GetPrice();

    }
}
