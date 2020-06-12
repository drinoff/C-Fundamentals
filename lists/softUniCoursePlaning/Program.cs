using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;

namespace softUniCoursePlaning
{
    class Program
    {
        static void Main(string[] args)
        {
            var schedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            var input = Console.ReadLine();

            while (input != "course start")
            {
                var command = input.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var action = command[0];
                switch (action)
                {
                    case "Add":
                        Add(schedule, command[1]);
                        break;
                    case "Insert":
                        var lesonTitle = command[1];
                        var index = int.Parse(command[2]);
                        Insert(schedule, lesonTitle, index);
                        break;
                    case "Remove":
                        Remove(schedule, command[1]);
                        break;
                    case "Swap":
                        Swap(schedule, command[1], command[2]);
                        break;
                    case "Exercise":
                        Exercise(schedule, command[1]);
                        break;

                }

                input = Console.ReadLine();

            }
            for (int i = 0; i <= schedule.Count - 1; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
        static List<string> Add(List<string> schedule, string lesonTitle)
        {
            if (!schedule.Contains(lesonTitle))
            {
                schedule.Add(lesonTitle);
            }
            return schedule;
        }
        static List<string> Insert(List<string> schedule, string lesonTitle, int index)
        {
            if (!schedule.Contains(lesonTitle))
            {

                if (index >= 0 && index < schedule.Count)
                {
                    schedule.Insert(index, lesonTitle);
                }
            }
            return schedule;
        }
        static List<string> Remove(List<string> schedule, string lesonTitle)
        {
            var index = schedule.IndexOf(lesonTitle);
            if (schedule.Contains(lesonTitle))
            {
                schedule.Remove(lesonTitle);
                if (schedule.Contains($"{lesonTitle}-Exercise"))
                {
                    schedule.Remove($"{lesonTitle}-Exercise");
                }
            }
          
            
            return schedule;
        }
        static List<string> Swap(List<string> schedule, string leson1, string leson2)
        {
            var index1 = schedule.IndexOf(leson1);
            var index2 = schedule.IndexOf(leson2);
            if (schedule.Contains(leson1) && schedule.Contains(leson2))
            {

                var temp = schedule[index1];
                schedule[index1] = schedule[index2];
                schedule[index2] = temp;
            }
            var temp2 = string.Empty;
            if (index1 + 1 <= schedule.Count - 1)
            {

                if (schedule[index1 + 1] == $"{leson1}-Exercise")
                {
                    if (index2 + 1 <= schedule.Count - 1)
                    {
                        schedule.Insert(index2 + 1, $"{leson1}-Exercise");
                        schedule.RemoveAt(index1 + 1);
                    }
                    else
                    {
                        schedule.Add($"{leson1}-Exercise");
                        schedule.RemoveAt(index1 + 2);
                    }
                }
            }
            if (index2 + 1 <= schedule.Count - 1)
            {
                if (schedule[index2 + 1] == $"{leson2}-Exercise")
                {
                    if (index1 + 1 <= schedule.Count - 1)
                    {
                        schedule.Insert(index1 + 1, $"{leson2}-Exercise");
                        schedule.RemoveAt(index2 + 2);
                    }
                    else
                    {
                        schedule.Add($"{leson2}-Exercise");
                        schedule.RemoveAt(index2 + 1);
                    }
                }
            }
            return schedule;
        }
        static List<string> Exercise(List<string> schedule, string lesonTitle)
        {
            if (schedule.Contains(lesonTitle))
            {
                if (!schedule.Contains($"{lesonTitle}-Exercise"))
                {
                    var index = schedule.IndexOf(lesonTitle);
                    schedule.Insert(index + 1, $"{lesonTitle}-Exercise");
                }
            }
            else
            {
                schedule.Add(lesonTitle);
                schedule.Add($"{lesonTitle}-Exercise");
            }
            return schedule;
        }
    }
}
