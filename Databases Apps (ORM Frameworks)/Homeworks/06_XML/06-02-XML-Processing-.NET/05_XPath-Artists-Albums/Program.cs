using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _05_XPath_Artists_Albums
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../01_Musical-Albums-in-XML.xml");

            Console.WriteLine("XML Document loaded !");
            Console.WriteLine();

            string artistsQuery = "/catalog/album/artist";

            Dictionary<string, int> artistsWithNumberOfAlbums =
                new Dictionary<string, int>();

            XmlNodeList artistsList = xmlDoc.SelectNodes(artistsQuery);

            foreach (XmlNode artistNode in artistsList)
            {
                string currArtist = artistNode.InnerText;

                string albumsForArtistQuery =
                    "/catalog/album[artist = \"" + currArtist + "\" ]";

                var albumsForArtistCount =
                    xmlDoc.SelectNodes(albumsForArtistQuery).Count;

                if (!artistsWithNumberOfAlbums.ContainsKey(currArtist))
                {

                    artistsWithNumberOfAlbums.Add(currArtist, albumsForArtistCount);
                }
            }

            foreach (var artist in artistsWithNumberOfAlbums)
            {
                Console.WriteLine("Artist: {0}, Albums: {1}", artist.Key, artist.Value);
            }

        }
    }
}
