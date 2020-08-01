using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace nikuldensMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            var guestMeals = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();
            var unliked = 0;
            while (input != "Stop")
            {
                var guestInfo = input.Split("-");
                var LikeOrNot = guestInfo[0];
                var guest = guestInfo[1];
                var meal = guestInfo[2];
                switch (LikeOrNot)
                {
                    case "Like":
                        if (!guestMeals.ContainsKey(guest))
                        {
                            guestMeals.Add(guest, new List<string>() { meal });
                        }
                        else
                        {
                            if (!guestMeals[guest].Contains(meal))
                            {
                                guestMeals[guest].Add(meal);
                            }
                        }
                        break;
                    case "Unlike":
                        if (!guestMeals.ContainsKey(guest))
                        {
                            Console.WriteLine($"{guest} is not at the party.");
                        }
                        else
                        {
                            if (!guestMeals[guest].Contains(meal))
                            {
                                Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                            }
                            else
                            {
                                guestMeals[guest].Remove(meal);
                                unliked++;
                                Console.WriteLine($"{guest} doesn't like the {meal}.");
                            }
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            foreach (var guest in guestMeals.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{guest.Key}: {string.Join(" ", guest.Value)}");

            };
            Console.WriteLine($"Unliked meals: {unliked}");

        }
    }


}
