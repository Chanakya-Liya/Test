// See https://aka.ms/new-console-template for more information
using Test;

List<Pizza> pizzas = new List<Pizza>();

Console.WriteLine("Welcome to Pizzaria");
while (true)
{
    Console.Write("Enter Pizza to buy Pizza, view to view all your pizzas or quit to go to checkout: ");
    string command = Console.ReadLine();

    if (string.Equals(command, "pizza", StringComparison.OrdinalIgnoreCase))
    {
        Pizza pizza = new Pizza();
        pizza.pizzaToppings();
        pizzas.Add(pizza);
    }
    else if (string.Equals(command, "view", StringComparison.OrdinalIgnoreCase))
    {
        viewPizza();

    }else if(string.Equals(command, "quit", StringComparison.OrdinalIgnoreCase))
    {
        Console.Write("Enter coupon code: ");
        Console.ReadLine();
        viewPizza();
        Console.WriteLine($"Total Price: ${totalPrice()}");
        break;

    }
    else
    {
        Console.WriteLine("Invalid Input");
    }
}

void viewPizza()
{
    int i = 1;
    foreach (Pizza pizza in pizzas)
    {
        Console.WriteLine($"{i}.Size: {pizza.size}");
        pizza.viewToppings();
        Console.WriteLine($"Price: ${pizza.price}");
        Console.WriteLine();
        i++;
    }
}

int totalPrice()
{
    int price = 0;
    foreach(Pizza pizza in pizzas)
    {
        price += pizza.price;
    }
    return price;
}

