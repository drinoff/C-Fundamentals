using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {           
            string username = Console.ReadLine();
            var usernameArr = username.ToCharArray();
            Array.Reverse(usernameArr);
            string password = string.Empty;

            for (int i = 0; i < usernameArr.Length; i++)
            {
                password += usernameArr[i];
            }
            
            var counter = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;                       
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }            
        }
    }
}
