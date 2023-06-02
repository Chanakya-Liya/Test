// See https://aka.ms/new-console-template for more information
using Test;
Console.WriteLine("Welcome to Pizza");
Maker make = new Maker();
while (true)
{
    Console.WriteLine("To make a Pizza enter pizza, To see all the pizzas you made enter view and to end enter quit");
    string command = Console.ReadLine().ToLower();

    if (command.Equals("pizza"))
    {
        Console.Write("What size pizza would you like: ");
        string size = Console.ReadLine().ToLower();
        if (size.Equals("small") || size.Equals("medium") || size.Equals("large"))
        {
            PizzaBuilder pizza = new PizzaBuilder(size);
            while (true)
            {
                Console.Write("Enter toppings or enter done to end: ");
                string topping = Console.ReadLine();
                if (topping.ToLower().Equals("done")) { break; }
                pizza.AddToppings(topping);
            }

            make.AddPizza(pizza.BuildPizza());
        }

    }else if (command.ToLower().Equals("view"))
    {
        make.GetDescription();
        Console.WriteLine(make.Pizzas.Count);
    }
    else if (command.ToLower().Equals("end"))
    {
        Console.WriteLine("Enter coupon code");
        Console.ReadLine();
        make.GetDescription();
        break;
    }
}