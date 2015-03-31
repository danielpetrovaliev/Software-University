using System.Threading;

namespace Export_International_Matches_XML
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Xml.Linq;

    using Football.Data;

    class ExportMatchesAsXML
    {
        private const string OutputPath = "../../../Generated-Files/international-matches.xml";

        static void Main(string[] args)
        {

            var footballContext = new FootballEntities();

            var matches = footballContext.InternationalMatches
                .Include(m => m.AwayCountry)
                .Include(m => m.HomeCountry)
                .Include(m => m.League)
                .OrderBy(m => m.MatchDate)
                .ThenBy(m => m.HomeCountry)
                .ThenBy(m => m.AwayCountry);

            var xmlDoc = new XDocument();
            var xmlRoot = new XElement("matches");
            xmlDoc.Add(xmlRoot);

            foreach (var match in matches)
            {
                var matchXmlElement = new XElement("match");

                if (match.MatchDate != null)
                {
                    var date = ((DateTime) match.MatchDate);

                    if (date.Hour == 0)
                    {
                        matchXmlElement.SetAttributeValue("date", date.ToString("dd-MMM-yy"));
                    }
                    else
                    {
                        matchXmlElement.SetAttributeValue("date-time", date.ToString("dd-MMM-yyyy hh:mm"));
                    }
                    
                }

                var homeCountryXmlElement = new XElement("home-country", match.HomeCountry.CountryName);
                homeCountryXmlElement.SetAttributeValue("code", match.HomeCountryCode);
                matchXmlElement.Add(homeCountryXmlElement);

                var awayCountryXmlElement = new XElement("away-country", match.AwayCountry.CountryName);
                awayCountryXmlElement.SetAttributeValue("code", match.AwayCountryCode);
                matchXmlElement.Add(awayCountryXmlElement);

                if (match.League != null)
                {
                    var leagueXmlElement = new XElement("league", match.League.LeagueName);
                    matchXmlElement.Add(leagueXmlElement);
                }

                if (match.AwayGoals != null && match.HomeGoals != null)
                {
                    string score = String.Format("{0} - {1}", match.HomeGoals, match.AwayGoals);
                    var scoreXmlElement = new XElement("score", score);
                    matchXmlElement.Add(scoreXmlElement);
                }

                xmlRoot.Add(matchXmlElement);
            }

            xmlDoc.Save(OutputPath);
            Console.WriteLine("XML report has been saved in : " + OutputPath);
        }
    }
}
