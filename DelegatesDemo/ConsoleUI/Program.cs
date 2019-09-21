using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static ShoppingCartModel cart = new ShoppingCartModel();

        static void Main(string[] args)
        {
            PopulateCartWithDemoData();
            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(Alert, CalculateDiscountedSubTotal, Alert):C2}");
            Console.WriteLine("******************");
            var total = cart.GenerateTotal(subTotal => Console.WriteLine($"The subtotal for cart 2 is {subTotal:C2}"),
                (items, subTotal) => items.Count > 3 ? subTotal * 0.50M : subTotal,
                message => Console.WriteLine(message)
                );

            Console.WriteLine($"The total for the cart2 is {total:C2}");

            Console.WriteLine();
            Console.Write("Please press any key to exit the application...");
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void Alert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");
        }

        private static void Alert(string message)
        {
            Console.WriteLine($"{message}");
        }

        private static decimal CalculateDiscountedSubTotal(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.95M;
            }
            else
            {
                return subTotal;
            }
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
    }
}
