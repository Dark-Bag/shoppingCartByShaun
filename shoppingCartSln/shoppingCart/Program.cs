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
            Console.WriteLine("WELCOME TO THE BAGGED GAMING SHOP\n");
            while (addingItems)
            {
               Console.WriteLine("ACTIONS: ");

                Console.WriteLine("Type '+' to add an item.");
                Console.WriteLine("Type 'display' to display the items.");
                Console.WriteLine("Type 'clear' to clear the cart list.");
                string name;
                double price;
              
                string action = Console.ReadLine();
                if (action == "+")
                {
                    Console.Write("What item would you like to add?: ");
                    name = Console.ReadLine();
                    Console.Write("Enter Item price: ");
                    price = double.Parse(Console.ReadLine());
                    ShoppingCartItem i = new ShoppingCartItem(name,price);
                    test.AddToTheCart(i);
                    
                }

                else if (action == "display")
                {
                    foreach (ShoppingCartItem it in test.GetCartItems())
                    {
                       Console.WriteLine( it.itemName +"........."+ 'R'+Math.Round(it.itemPrice, 2));
                    }
                    Console.WriteLine("Sub Total:........." + 'R' + test.subTotal());
                    Console.WriteLine("Sub Total (VAT incl.):........." + 'R' + test.subTotalWithVAT());

                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                 

                }

                else if (action == "clear")
                {
                    test.Clear();
                        

                }

            }
           
        }
    }
}
