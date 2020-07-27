using System;
using System.Text;
using System.Text.RegularExpressions;

namespace passwordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();
            var input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            while (input != "Done")
            {
                var command = input.Split();
                var action = command[0];
                switch (action)
                {
                    case "TakeOdd":
                        for (int i = 0; i < password.Length; i++)
                        {
                            if(i%2 !=0)
                            {
                                sb.Append(password[i]);
                            }
                        }
                        password = sb.ToString();
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        var index = int.Parse(command[1]);
                        var length = int.Parse(command[2]);
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        var substring = command[1];
                        var substitute = command[2];
                        if (password.Contains(substring))
                        {
                            password = Regex.Replace(password, substring,substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
            
        }
    }
}
