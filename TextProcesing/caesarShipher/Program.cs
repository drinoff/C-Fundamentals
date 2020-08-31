using System;
using System.Text;

namespace caesarShipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            StringBuilder sb = new StringBuilder();
            
            
            for (int i = 0; i < text.Length; i++)
            {
                var chr = (char)(text[i] + 3);
                
                sb.Append(chr);
                    
            }
            
        Console.WriteLine(sb.ToString());
        }
    }
}
