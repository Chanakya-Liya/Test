using System.Collections;
using System.Collections.Generic;

namespace Test
{
    internal class Pizza
    {
        public string size;
        public ArrayList toppings = new ArrayList();
        public int price = 0;

        public Pizza()
        {
            while (true)
            {
                Console.Write("What size Pizza would you like: ");
                string size = Console.ReadLine();
                if (string.Equals(size, "small", StringComparison.OrdinalIgnoreCase))
                {
                    this.size = size;
                    price += 10;
                    break;
                }
                else if (string.Equals(size, "medium", StringComparison.OrdinalIgnoreCase))
                {
                    this.size = size;
                    price += 12;
                    break;
                }
                else if (string.Equals(size, "large", StringComparison.OrdinalIgnoreCase))
                {
                    this.size = size;
                    price += 14;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Pizza size");
                }
            }
           
        }

        public void pizzaToppings()
        {
            while(true)
            {
                Console.Write("What toppings would you like(Or enter done to end): ");
                string topping = Console.ReadLine();
                if (string.Equals(topping, "cheese", StringComparison.OrdinalIgnoreCase) ||
                   string.Equals(topping, "ham", StringComparison.OrdinalIgnoreCase) ||
                   string.Equals(topping, "pepperoni", StringComparison.OrdinalIgnoreCase))
                {
                    toppings.Add(topping);
                    Console.WriteLine($"{topping} added");
                    price += 2;

                }else if(string.Equals(topping,"done", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid topping");
                }
                Console.WriteLine();
            }
        }

        public void viewToppings()
        {
            foreach(string topping in toppings)
            {
                Console.WriteLine($" -{topping}");
            }
        }
    }
}
