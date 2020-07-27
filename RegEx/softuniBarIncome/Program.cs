using System;
using System.Text.RegularExpressions;

namespace softuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quant>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            var totalIncome = 0.0;
            while (input != "end of shift")
            {
                bool hasMatch = Regex.IsMatch(input, pattern);
                if (hasMatch)
                {


                    var line = Regex.Match(input, pattern);

                    var name = line.Groups["name"].Value;
                    var product = line.Groups["product"].Value;
                    var quantity = double.Parse(line.Groups["quant"].Value);
                    var price = double.Parse(line.Groups["price"].Value);
                    var currentProductPrice = price * quantity;
                    Console.WriteLine($"{name}: {product} - {currentProductPrice:f2}");
                    totalIncome += currentProductPrice;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
