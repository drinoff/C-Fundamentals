using System;
using System.Linq;

namespace emailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();
            var input = Console.ReadLine();
            while (input !="Complete")
            {
                var command = input.Split();
                var action = command[0];
                switch (action)
                {
                    case "Make":
                        var upperOrLower = command[1];
                        switch (upperOrLower)
                        {
                            case "Upper":
                                email = email.ToUpper();
                                Console.WriteLine(email);
                                break;
                            case "Lower":
                                email = email.ToLower();
                                Console.WriteLine(email);
                                break;
                        }
                        break;
                    case "GetDomain":
                        var count = int.Parse(command[1]);
                        var domain = email.TakeLast(count);
                        var result = string.Join("", domain);
                        Console.WriteLine(result);
                        break;
                    case "GetUsername":
                        if(!email.Contains("@"))
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        else 
                        {
                            var index = email.IndexOf("@");
                            var subString = email.Substring(0, index);
                            Console.WriteLine(subString);
                        }
                        break;
                    case "Replace":
                        var charToReplace = command[1];
                        email = email.Replace(charToReplace, "-");
                        Console.WriteLine(email);
                        break;
                    case "Encrypt":
                        var asciValues = string.Empty;
                        for (int i = 0; i < email.Length; i++)
                        {
                            asciValues += (int)email[i] + " ";
                        }
                            Console.WriteLine(asciValues);
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
