using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Processing_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePathXml = "../../softuniRssFeed.xml";
            const string filePathJson = "../../softuniRssFeed.json";
            const string filePathHtml = "../../softuniRssFeed.html";

            // ===========================================================================
            // Problem 1.	Download the content of the SoftUni RSS feed
            // ===========================================================================
            var webClient = new WebClient();
            webClient.DownloadFile("https://softuni.bg/Feed/News", filePathXml);
            Console.WriteLine("SoftUni Rss Feed has been downloaded at: " + filePathXml);
            Console.WriteLine();

            // ===========================================================================
            // Problem 2.	Parse the XML from the feed to JSON
            // ===========================================================================
            var doc = XDocument.Load(filePathXml);

            var rssJson = JsonConvert.SerializeXNode(doc, Formatting.Indented);
            var jsonAsString = rssJson.ToString();
            var jsonObjLinq = JObject.Parse(jsonAsString);

            // ===========================================================================
            // Problem 3.	Using LINQ-to-JSON select all the question titles and print them to the console
            // ===========================================================================
            var questionTitles = jsonObjLinq["rss"]["channel"]["item"]
                .Select(p =>
                    String.Format("{0}", p["title"]));

            foreach (var title in questionTitles)
            {
                Console.WriteLine(title);
            }

            // ===========================================================================
            // Problem 4.	Parse the JSON string to POCO
            // ===========================================================================
            var questions = jsonObjLinq["rss"]["channel"]["item"];

            var parsedQuestions = JsonConvert.DeserializeObject<IEnumerable<Question>>(questions.ToString());

            // ===========================================================================
            // Problem 5.	Using the parsed objects create a HTML page that lists all
            // questions from the RSS their categories and a link to the question’s page.

            var htmlString = new StringBuilder();
            
            htmlString.AppendLine("<!DOCTYPE html>");
            htmlString.AppendLine("<html>");
            htmlString.AppendLine("<head>");
            htmlString.AppendLine("<meta charset=\"UTF-8\">");
            htmlString.AppendLine("</head>");
            htmlString.AppendLine("<body>");

            foreach (var question in parsedQuestions)
            {
                htmlString.AppendLine(String.Format("<a href={0}><h2>{1}</h2></a>", question.Link, question.Title));
            }

            htmlString.AppendLine("</body>");
            htmlString.AppendLine("</html>");

            // Save html file
            File.WriteAllText(filePathHtml, htmlString.ToString());
            Console.WriteLine();
            Console.WriteLine("Html file has been saved at: " + filePathHtml);

            // Save json to file
            File.WriteAllText(filePathJson, rssJson.ToString());
            Console.WriteLine();
            Console.WriteLine("Json file has been saved at: " + filePathJson);

        }
    }
}
