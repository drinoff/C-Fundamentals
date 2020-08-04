using System;
using System.Text;
using System.Text.RegularExpressions;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputCount = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            for (int i = 0; i < inputCount; i++)
            {
                var pattern = @"^(.+)>(?<midGrp1>\d{3})\|(?<midGrp2>[a-z]{3})\|(?<midGrp3>[A-Z]{3})\|(?<midGrp4>[^<>]{3})<\1$";
                if(Regex.IsMatch(input,pattern))
                {
                    var validPassword = Regex.Match(input, pattern);
                    sb.Append(validPassword.Groups["midGrp1"].Value);
                    sb.Append(validPassword.Groups["midGrp2"].Value);
                    sb.Append(validPassword.Groups["midGrp3"].Value);
                    sb.Append(validPassword.Groups["midGrp4"].Value);
                    Console.WriteLine($"Password: { sb.ToString()}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }

                input = Console.ReadLine();
                sb.Clear();
            }
        }
    }
}
