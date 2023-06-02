using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class PizzaBuilder
    {
        public Pizza pizza;

        public PizzaBuilder(string size)
        {
            switch (size.ToLower())
            {
                case "small":
                    pizza = new SmallPizza();
                    break;
                case "medium":
                    pizza = new MediumPizza();
                    break;
                case "large":
                    pizza = new LargePizza();
                    break;
                default:
                    Console.WriteLine("Invalid Input Please select small, medium or large");
                    break;
            }
        }
        public void AddToppings(string topping) 
        {
            if(topping.ToLower().Equals("ham") || topping.ToLower().Equals("cheese") || topping.ToLower().Equals("Pepperoni"))
            {
                pizza.PizzaToppings(topping);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
        }

        public Pizza BuildPizza()
        {
            return pizza;
        }
    }
}
