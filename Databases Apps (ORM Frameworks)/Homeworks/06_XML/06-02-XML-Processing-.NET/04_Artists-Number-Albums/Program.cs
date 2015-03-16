using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _04_Artists_Number_Albums
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../01_Musical-Albums-in-XML.xml");

            Console.WriteLine("XML Document loaded!");
            Console.WriteLine();

            XmlNode rootNode = doc.DocumentElement;

            Dictionary<string, int> artistsWithNumberOfAlbums = 
                new Dictionary<string, int>();

            foreach (XmlNode albumNode in rootNode.ChildNodes)
            {
                var currArtist = albumNode["artist"].InnerText;

                int numberOfalbumsForThisArtist = rootNode.ChildNodes.Cast<XmlNode>()
                    .Count(
                        otherAlbumNode =>
                            otherAlbumNode["artist"].InnerText == currArtist);
                
                if(!artistsWithNumberOfAlbums.ContainsKey(currArtist))
                {
                    artistsWithNumberOfAlbums.Add(currArtist, numberOfalbumsForThisArtist);
                    
                }
            }

            foreach (var artist in artistsWithNumberOfAlbums)
            {
                Console.WriteLine("Artist: {0}, Albums: {1}", artist.Key, artist.Value);
            }
        }
    }
}
