using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using Football.Data;

namespace Import_Leagues_and_Teams_from_XML
{
    class ImportLeaguesAndTeams
    {
        private const string DocumentPath = "../../../Files-for-import/leagues-and-teams.xml";
        private static int counter = 1;
        static void Main(string[] args)
        {
            var doc = XDocument.Load(DocumentPath);

            TraverseXmlDocument(doc);
        }

        private static void TraverseXmlDocument(XDocument doc)
        {
            foreach (var leagueElement in doc.XPathSelectElements("leagues-and-teams/league"))
            {
                AddLeague(leagueElement);
            }
        }

        private static void AddLeague(XElement leagueElement)
        {
            Console.WriteLine("Processing league #" + counter++ + " ...");

            var context = new FootballEntities();

            var leagueName = leagueElement.Element("league-name") != null
                    ? leagueElement.Element("league-name").Value
                    : null;

            if (leagueName == null)
            {
                AddTeams(leagueElement);
            }
            else
            {
                var teamElements = leagueElement.XPathSelectElements("teams/team");

                // If league exist
                if (context.Leagues.Any(l => l.LeagueName == leagueName))
                {
                    var existingLeague = context.Leagues.FirstOrDefault(l => l.LeagueName == leagueName);
                    Console.WriteLine("Existing league: {0}", existingLeague.LeagueName);

                    AddTeamsIntoLeague(existingLeague, teamElements, context);
                    context.SaveChanges();
                }
                else
                {
                    var newLeague = new League
                    {
                        LeagueName = leagueName
                    };
                    Console.WriteLine("Created league: {0}", newLeague.LeagueName);

                    AddTeamsIntoLeague(newLeague, teamElements, context);
                    context.Leagues.Add(newLeague);
                    context.SaveChanges();
                }


            }
            Console.WriteLine();
        }

        private static void AddTeamsIntoLeague(League league, IEnumerable<XElement> teamElements, FootballEntities context)
        {
            foreach (var teamElement in teamElements)
            {
                if (teamElement.Attribute("name") == null)
                {
                    throw new ArgumentException("Atribute \"name\" is required.");
                }

                var currTeamCountryName = teamElement.Attribute("country") != null
                    ? teamElement.Attribute("country").Value
                    : null;
                var teamName = teamElement.Attribute("name").Value;

                // If this team exist
                if (context.Teams.Any(t => t.TeamName == teamName && t.Country.CountryName == currTeamCountryName))
                {
                    var existingTeam =
                        context.Teams.FirstOrDefault(
                            t => t.TeamName == teamName && t.Country.CountryName == currTeamCountryName);

                    Console.WriteLine("Existing team: {0} ({1})", existingTeam.TeamName,
                        existingTeam.Country != null ? existingTeam.Country.CountryName : "no country");

                    // If this team is in this league
                    if (league.Teams.Any(t => t.TeamName == existingTeam.TeamName && t.Country == existingTeam.Country))
                    {
                        Console.WriteLine("Existing team in league: {0} belongs to {1}", existingTeam.TeamName, league.LeagueName);
                    }
                    else
                    {
                        league.Teams.Add(existingTeam);
                        context.SaveChanges();

                        Console.WriteLine("Added team to league: {0} to league {1}", existingTeam.TeamName,
                        league.LeagueName);
                    }
                }
                else
                {
                    var newTeam = new Team
                    {
                        TeamName = teamName,
                        Country = context.Countries.FirstOrDefault(c => c.CountryName == currTeamCountryName)
                    };

                    context.Teams.Add(newTeam);
                    context.SaveChanges();

                    Console.WriteLine("Created team: {0} ({1})", newTeam.TeamName,
                        newTeam.Country != null ? newTeam.Country.CountryName : "no country");

                    league.Teams.Add(newTeam);
                    context.SaveChanges();

                    Console.WriteLine("Added team to league: {0} to league {1}", newTeam.TeamName,
                        league.LeagueName);
                }
            }
        }

        private static void AddTeams(XElement leagueElement)
        {
            var context = new FootballEntities();

            foreach (var teamElement in leagueElement.XPathSelectElements("teams/team"))
            {
                if (teamElement.Attribute("name") == null)
                {
                    throw new ArgumentException("Team name is required.");
                }

                var currTeamCountryName = teamElement.Attribute("country") != null
                    ? teamElement.Attribute("country").Value
                    : null;
                var teamName = teamElement.Attribute("name").Value;

                if (context.Teams.Any(t => t.TeamName == teamName && t.Country.CountryName == currTeamCountryName))
                {
                    var existingTeam =
                        context.Teams.FirstOrDefault(
                            t => t.TeamName == teamName && t.Country.CountryName == currTeamCountryName);

                    Console.WriteLine("Existing team: {0} ({1})", existingTeam.TeamName,
                        existingTeam.Country != null ? existingTeam.Country.CountryName : "no country");
                }
                else
                {
                    var newTeam = new Team
                    {
                        Country = context.Countries.FirstOrDefault(c => c.CountryName == currTeamCountryName),
                        TeamName = teamName
                    };

                    context.Teams.Add(newTeam);
                    context.SaveChanges();
                    Console.WriteLine("Created team: {0} ({1})", newTeam.TeamName,
                        newTeam.Country != null ? newTeam.Country.CountryName : "no country");
                }
            }
        }
    }
}
