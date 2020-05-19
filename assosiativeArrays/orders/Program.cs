using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace orders
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, double> products = new Dictionary<string, double>();            
            var finProd = new Dictionary<string, double>();
            var resultProd = new Dictionary<string, double>();           
            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] product = command.Split().ToArray();
                
                    string name = product[0];
                    double price = double.Parse(product[1]);
                    double quantity = double.Parse(product[2]);

                
                

                    if (products.ContainsKey(name) == false)
                    {
                        products.Add(name, price);
                        finProd.Add(name, 0);
                    }
                    products[name] = price;
                    finProd[name] += quantity;
                    resultProd[name] = products[name] * finProd[name];
                    

                                                                            
                
                command = Console.ReadLine();                
            }
            foreach (var item in resultProd)
            {
                Console.WriteLine($"{item.Key:f2} -> {item.Value:f2}");
            }
        }      
    }
}
