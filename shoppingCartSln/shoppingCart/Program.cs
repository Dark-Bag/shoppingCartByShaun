using ShoppingCartLib;
using System;

namespace shoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart test = new Cart();

            bool addingItems = true;

            while (addingItems)
            {
                Console.WriteLine("Type '+' to add an item.");
                Console.WriteLine("Type 'display' to display the items.");
                string name;
                double price;
                string action = Console.ReadLine();
                if (action == "+")
                {
                    Console.Write("What item would you like to add?: ");
                    name = Console.ReadLine();
                    Console.Write("Enter Item price: ");
                    price = double.Parse(Console.ReadLine());
                    test.AddToTheCart(name, price);
                    break;
                }

                else if (action == "display")
                {
                    foreach (string itemName in test.GetCartItemNames())
                    {
                        Console.WriteLine(itemName);
                    }

                }
                
            }
           
        }
    }
}
