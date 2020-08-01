using System;
using System.Text;
using System.Text.RegularExpressions;

namespace isleOfManTTRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string pattern = @"^([#\$%\*&])(?<name>[A-Za-z]+)\1\=(?<number>\d+)!!(?<code>.+)$";
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                if(Regex.IsMatch(input,pattern))
                {
                    var driverInfo = Regex.Match(input, pattern);
                    if (int.Parse(driverInfo.Groups["number"].Value) == driverInfo.Groups["code"].Value.Length)
                    {
                        var driver = driverInfo.Groups["name"].Value;
                        var code = driverInfo.Groups["code"].Value;
                        var padding = int.Parse(driverInfo.Groups["number"].Value);
                        var codeArray = code.ToCharArray();
                        for (int i = 0; i < code.Length; i++)
                        {
                            sb.Append((char)(codeArray[i] + padding));
                        }
                        Console.WriteLine($"Coordinates found! {driver} -> {sb.ToString()}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                        Console.WriteLine("Nothing found!");

                }
                input = Console.ReadLine();
            }
        }
    }
}
