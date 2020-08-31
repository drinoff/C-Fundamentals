using System;

namespace extractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine().Split("\\");
            var lastString = path[path.Length - 1];

            var splittedString = lastString.Split(".");
            var filename = splittedString[0];
            var extension = splittedString[1];
            Console.WriteLine($"File name: {filename}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
