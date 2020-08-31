using System;
using System.Collections.Generic;

namespace validUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var userNames = Console.ReadLine().Split(", ");
            var notValid = false;
            var validUsers = new List<string>();

            for (int i = 0; i < userNames.Length; i++)
            {
                if (userNames[i].Length >= 3 && userNames[i].Length <= 16)
                {
                    var currentUserName = userNames[i].ToCharArray();
                    for (int j = 0; j < currentUserName.Length; j++)
                    {
                        if (char.IsDigit(currentUserName[j])
                            || char.IsLetter(currentUserName[j])
                            || currentUserName[j] == '-'
                            || currentUserName[j] == '_')
                        {
                            notValid = false;
                            continue;
                        }
                        else
                        {
                            notValid = true;
                            break;
                        }
                    }
                    if (notValid == false)
                    {
                        validUsers.Add(userNames[i]);
                        
                    }
                }
            }
            foreach (var item in validUsers)
            {
                Console.WriteLine(item);
            }
        }




    }
}
