using System;
using System.Linq;

namespace nikuldensCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            var encryptedMoney = Console.ReadLine();
            var input = Console.ReadLine();

            while (input != "Finish")
            {
                var command = input.Split();
                var action = command[0];
                switch (action)
                {
                    case "Replace":
                        var currentChar = command[1];
                        var newChar = command[2];
                        encryptedMoney = encryptedMoney.Replace(currentChar, newChar);
                        Console.WriteLine(encryptedMoney);
                        break;
                    case "Cut":
                        var startIndex = int.Parse(command[1]);
                        var endIndex = int.Parse(command[2]);
                        if (startIndex >= 0 && startIndex < encryptedMoney.Length && endIndex >= 0 && endIndex < encryptedMoney.Length)
                        {
                            encryptedMoney = encryptedMoney.Remove(startIndex, (endIndex - startIndex)+1);
                            Console.WriteLine(encryptedMoney);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                        break;
                    case "Make":
                        var upperOrLower = command[1];
                        if(upperOrLower == "Upper")
                        {
                            encryptedMoney = encryptedMoney.ToUpper();
                            Console.WriteLine(encryptedMoney);
                        }
                        else
                        {
                            encryptedMoney = encryptedMoney.ToLower();
                            Console.WriteLine(encryptedMoney);
                        }
                        break;
                    case "Check":
                        var subString = command[1];
                        if(encryptedMoney.Contains(subString))
                        {
                            Console.WriteLine($"Message contains {subString}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {subString}");
                        }
                        break;
                    case "Sum":
                        startIndex = int.Parse(command[1]);
                        endIndex = int.Parse(command[2]);
                        if (startIndex >= 0 && startIndex < encryptedMoney.Length && endIndex >= 0 && endIndex < encryptedMoney.Length)
                        {
                            var toCalculate = encryptedMoney.Substring(startIndex, (endIndex - startIndex)+1);
                            var sum = 0;
                            for (int i = 0; i < toCalculate.Length; i++)
                            {
                                sum += toCalculate[i];
                            }
                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                            break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
