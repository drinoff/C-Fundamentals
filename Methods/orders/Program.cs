using System;

namespace orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            TotalPrice(product, quantity);
        }

        static void TotalPrice(string product, double quantity)
        {
            double totalPrice = 0;
            if (product == "coffee")
            {
                totalPrice = quantity * 1.5;
            }

            else if (product == "coke")
            {
                totalPrice = quantity * 1.4;  
            }

            else if (product == "water")
            {
                totalPrice = quantity * 1;
            }

            else
            {
                totalPrice = quantity * 2;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
