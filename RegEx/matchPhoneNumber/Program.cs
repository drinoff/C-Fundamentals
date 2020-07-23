using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace matchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\+[3][5][9]( |-)[2]\1[0-9]{3}\1[0-9]{4}\b";
            var phoneNumbers = Regex.Matches(Console.ReadLine(), pattern);
            
            
           var result = string.Join(", ", phoneNumbers);
            Console.WriteLine(result.Trim());
        }
    }
}
