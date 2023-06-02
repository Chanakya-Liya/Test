using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Maker
    {
        public List<Pizza> Pizzas { get; set; }

        public Maker()
        {
            Pizzas = new List<Pizza>();
        }

        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }

        public void GetDescription()
        {
            int price = 0;
            for (int i = 0; i < Pizzas.Count; i++) {           
                Console.WriteLine("Size: " + Pizzas[i].Size);
                Pizzas[i].ViewPizza();
                price += Pizzas[i].GetPrice();
                Console.WriteLine(Pizzas[i].GetPrice());
                Console.WriteLine();
            }
            Console.WriteLine("Total Price: "  + price);
        }
    }
}
