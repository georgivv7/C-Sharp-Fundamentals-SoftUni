using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teamsList = new List<Team>();

            for (int i = 0; i < n; i++)
            {          
                var input = Console.ReadLine().Split("-",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creator = input[0];
                string teamName = input[1];
                Team team = new Team(teamName, creator);
                
                if (teamsList.Any(x=>x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teamsList.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    teamsList.Add(team);
                }
                
            }
 
            while (true)
            {
                var command = Console.ReadLine().Split("->",StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "end of assignment")
                {
                    break;
                }
                string member = command[0];
                string teamName = command[1];
                if (!teamsList.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (teamsList.Any(x => x.peopleJoined.Contains(member))
                    || teamsList.Any(x=>x.Creator == member && teamsList.Any(x=>x.Name == teamName))) 
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }
                int index = teamsList.FindIndex(x => x.Name == teamName);
                teamsList[index].peopleJoined.Add(member);

            }
            var teamsDisbanded = teamsList.FindAll(x => x.peopleJoined.Count == 0)
                .OrderBy(x => x.Name).ToList();
            var validTeams = teamsList.OrderByDescending(x=>x.peopleJoined.Count)
                .ThenBy(x => x.Name).ToList();

            foreach (var team in validTeams.Where(x=>x.peopleJoined.Count > 0))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.Creator);
                team.peopleJoined.Sort();
                foreach (var member in team.peopleJoined.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }            

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsDisbanded)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }

        public List<string> peopleJoined;

        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            peopleJoined = new List<string>();
        }

    }
}
