// See https://aka.ms/new-console-template for more information
using Test;

List<Pizza> pizzas = new List<Pizza>();

Console.WriteLine("Welcome to Pizzaria");
while (true)
{
    Console.Write("Enter Pizza size, Enter view to view all your pizzas or Enter quit to end: ");
    string size = Console.ReadLine();

    if (string.Equals(size, "quit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    if (string.Equals(size, "small", StringComparison.OrdinalIgnoreCase) ||
        string.Equals(size, "medium", StringComparison.OrdinalIgnoreCase) ||
        string.Equals(size, "large", StringComparison.OrdinalIgnoreCase))
    {
        Pizza pizza = new Pizza(size);

        switch (size.ToLower())
        {
            case "small":
                pizza.price += 10;
                break;
            case "medium":
                pizza.price += 12;
                break;
            case "large":
                pizza.price += 14;
                break;
        }

        while (true)
        {
            Console.WriteLine();
            Console.Write("Enter toppings or Enter done to end: ");

            string topping = Console.ReadLine();

            if (string.Equals(topping, "done", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
                break;
            }
            if (string.Equals(topping, "Cheese", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(topping, "ham", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(topping, "pepperoni", StringComparison.OrdinalIgnoreCase))
            {
                pizza.toppings.Add(topping);
                pizza.price += 2;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input please enter cheese, ham or pepperoni");
            }

        }
        pizzas.Add(pizza);

    }
    else if (String.Equals(size, "view", StringComparison.OrdinalIgnoreCase))
    {
        int j = 1;
        foreach (Pizza pizza in pizzas)
        {
            Console.WriteLine(j + ".");
            Console.WriteLine("Size: " + pizza.size);
            Console.WriteLine("Toppings:");

            foreach (string topping in pizza.toppings)
            {
                Console.WriteLine("- " + topping);
            }
            Console.WriteLine("Price: $"+pizza.price);

            Console.WriteLine();
            j++;
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input");
        Console.WriteLine("Please enter small medium or large");
    }
}

Console.WriteLine();
Console.Write("Enter coupon code: ");
string coupon = Console.ReadLine();
Console.WriteLine();

int i = 1;
foreach (Pizza pizza in pizzas)
{
    Console.WriteLine(i + ".");
    Console.WriteLine("Size: " + pizza.size);
    Console.WriteLine("Toppings:");

    foreach (string topping in pizza.toppings)
    {
        Console.WriteLine("- " + topping);
    }
    Console.WriteLine("Price: $" + pizza.price);

    Console.WriteLine();
    i++;
}

Console.WriteLine();
int TotalPrice = 0;
Console.Write("Total Price: $");
foreach (Pizza pizza in pizzas)
{
    TotalPrice += pizza.price;
}
Console.WriteLine(TotalPrice);