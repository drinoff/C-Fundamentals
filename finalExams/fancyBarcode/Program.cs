using System;
using System.Text;
using System.Text.RegularExpressions;

namespace fancyBarcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var barcodesCount = int.Parse(Console.ReadLine());
            var pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            StringBuilder sb = new StringBuilder();

            var barcode = Console.ReadLine();
            for (int i = 0; i < barcodesCount; i++)
            {
                bool hasMatched = Regex.IsMatch(barcode, pattern);
                if (hasMatched)
                {
                    for (int j = 0; j < barcode.Length; j++)
                    {
                        if (char.IsDigit(barcode[j]))
                        {
                            sb.Append(barcode[j]);
                        }
                    }
                    if (sb.Length == 0)
                    {

                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {

                        Console.WriteLine($"Product group: {sb.ToString()}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
                sb.Clear();
                barcode = Console.ReadLine();
            }
        }
    }
}
