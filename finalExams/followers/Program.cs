using System;
using System.Collections.Generic;
using System.Linq;

namespace followers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var followerLike = new Dictionary<string, int>();
            var followerComment = new Dictionary<string, int>();

            while (input != "Log out")
            {
                var command = input.Split(": ");
                var action = command[0];
                switch (action)
                {
                    case "New follower":
                        var username = command[1];
                        if(!followerLike.ContainsKey(username))
                        {
                            followerLike.Add(username, 0);
                            followerComment.Add(username, 0);
                        } 
                        break;
                    case "Like":
                        username = command[1];
                        var count = int.Parse(command[2]);
                        if(!followerLike.ContainsKey(username))
                        {
                            followerLike.Add(username, 0);
                            followerComment.Add(username, 0);
                        }
                        
                        
                            followerLike[username] += count;
                        
                        break;
                    case "Comment":
                        username = command[1];
                        if(!followerComment.ContainsKey(username))
                        {
                            followerComment.Add(username, 1);
                            followerLike.Add(username, 0);
                        }
                        else
                        {
                            followerComment[username] += 1;
                        }
                        break;
                    case "Blocked":
                        username = command[1];
                        if(!followerLike.ContainsKey(username))
                        {
                            Console.WriteLine($"{username} doesn't exist.");
                        }
                        else
                        {
                            followerLike.Remove(username);
                            followerComment.Remove(username);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Dictionary<string, int> result = (from e in followerLike.Concat(followerComment)
                                              group e by e.Key into g
                                              select new { Name = g.Key, Count = g.Sum(kvp => kvp.Value) })
              .ToDictionary(item => item.Name, item => item.Count);

            Console.WriteLine($"{followerLike.Count} followers");
            foreach (var follower in result.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{follower.Key}: {follower.Value}");
            }
            
        }
    }
}
