using System;

namespace Football.Data
{
    public class ListAllTeamNames
    {
        public static void Main()
        {
            var footballContext = new FootballEntities();

            foreach (var team in footballContext.Teams)
            {
                Console.WriteLine("Team: {0}", team.TeamName);
            }
        }
    }
}