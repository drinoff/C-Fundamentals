using System;
using System.Text;
using System.Text.RegularExpressions;

namespace textFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var banned = Console.ReadLine().Split(", ");
            var text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < banned.Length; i++)
            {
                var replacement = string.Empty;
                var count = banned[i].Length;
                for (int j = 0; j < count; j++)
                {
                    sb.Append("*");
                    replacement = sb.ToString();
                }
                text = Regex.Replace(text, banned[i], replacement);
                sb.Clear();
            }
            Console.WriteLine(text);
        }
    }
}
