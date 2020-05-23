using System;
using System.Linq;
using System.Text;

namespace decryptingMesseges
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var lines = int.Parse(Console.ReadLine());
            var message = new StringBuilder();

            for (int i = 0; i < lines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                var number = (int)letter;
                number += key;
                var finalChar = (char)number;
                message.Append(finalChar);
            }
            Console.WriteLine(message);
        }
    }
}
