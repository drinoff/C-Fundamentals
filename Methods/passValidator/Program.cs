using System;
using System.Linq;

namespace passValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            var result = CheckPassLength(password);
            var result1 = OnlyLettersAndDigitsChecker(password);
            var result2 = IfMinTwoDigits(password);
            
             
            if (result1 && result2 && result)
                Console.WriteLine("Password is valid");
        }
        static bool CheckPassLength(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
                return false;
            }
            else
                return true;
                
        }
        static bool OnlyLettersAndDigitsChecker(string password)
        {
            bool hasDigit = true;
            
          
                hasDigit = password.All(password => char.IsLetterOrDigit(password));


            if (hasDigit == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
            else
                return true;
        }
        static bool IfMinTwoDigits(string password)
        {
            int count = password.Count(x => Char.IsDigit(x));
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            else
                return true;
        }
    }
}
