using System;

namespace Export_Leagues_and_Teams_as_JSON
{
    using System.IO;
    using System.Linq;

    using Football.Data;
    using Newtonsoft.Json;

    class ExportLeaguesAsJson
    {
        private const string OutputPath = "../../../Generated-Files/leagues-and-teams.json";

        static void Main(string[] args)
        {
            var context = new FootballEntities();

            var leaguesWithTeamsQuery = context.Leagues
                .Select(l =>
                    new
                    {
                        leagueName = l.LeagueName,
                        teams = l.Teams
                            .OrderBy(t => t.TeamName)
                            .Select(t => t.TeamName)
                    })
                .OrderBy(l => l.leagueName);

            var json = JsonConvert.SerializeObject(leaguesWithTeamsQuery.ToList(), Formatting.Indented);

            File.WriteAllText(OutputPath, json);
            Console.WriteLine("JSON report has been saved in : " + OutputPath);
        }
    }
}
