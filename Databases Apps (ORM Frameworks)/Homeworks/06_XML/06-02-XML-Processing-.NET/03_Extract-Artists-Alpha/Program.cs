using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03_Extract_Artists_Alpha
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

            SortedSet<string> artists = new SortedSet<string>();

            foreach (XmlNode albumNode in rootNode.ChildNodes)
            {
                artists.Add(albumNode["artist"].InnerText);
            }

            foreach (var artist in artists)
            {
                Console.WriteLine("Artist: {0}", artist);
            }
        }
    }
}
