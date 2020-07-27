using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    public class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teamsList = new List<Team>();
            List<string> creatorsList = new List<string>();
            List<string> teamsName = new List<string>();
            List<string> members = new List<string>();

            for (int i = 0; i < countOfTeams; i++)
            {
                var line = Console.ReadLine().Split('-');
                var creator = line[0];
                var teamName = line[1];

                var team = new Team()
                {
                    TeamName = teamName,
                    Creator = creator,
                    Members = new List<string>()
                };

                if (teamsName.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");

                }
                if (creatorsList.Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");

                }

                if (!creatorsList.Contains(creator) && !teamsName.Contains(teamName))
                {
                    teamsList.Add(team);
                    creatorsList.Add(creator);
                    teamsName.Add(teamName);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                var line = input.Split("->");
                var user = line[0];
                var teamName = line[1];

                if (!teamsName.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");

                }
                if (creatorsList.Contains(user) || members.Contains(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");

                }
                if (teamsName.Contains(teamName) && !creatorsList.Contains(user) && !members.Contains(user))
                {
                    var currentTeam = teamsList.FirstOrDefault(n => n.TeamName == teamName);
                    currentTeam.Members.Add(user);
                    members.Add(user);
                }
            }

            foreach (var team in teamsList.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName).Where(x => x.Members.Count > 0))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var user in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {user}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsList.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0))
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }
    }
}
