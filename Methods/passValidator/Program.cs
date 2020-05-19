using System;
using System.Linq;

namespace passValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CheckPassLength(password);
            OnlyLettersAndDigitsChecker(password);
            IfMinTwoDigits(password);
             
            if (CheckPassLength(password) && OnlyLettersAndDigitsChecker(password) && IfMinTwoDigits(password))
        }
        static void CheckPassLength(string password)
        {
            if (password.Length < 6 || password.Length > 10)
                Console.WriteLine($"Password must be between 6 and 10 characters");
        }
        static void OnlyLettersAndDigitsChecker(string password)
        {
            bool hasDigit = true;
            
          
                hasDigit = password.All(password => char.IsLetterOrDigit(password));

         
            if (hasDigit == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
        }
        static void IfMinTwoDigits(string password)
        {
            int count = password.Count(x => Char.IsDigit(x));
            if (count<2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
}
