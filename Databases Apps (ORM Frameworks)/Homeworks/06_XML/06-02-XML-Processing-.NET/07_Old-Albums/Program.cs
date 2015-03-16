using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _07_Old_Albums
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../01_Musical-Albums-in-XML.xml");

            Console.WriteLine("XML Document loaded !");
            Console.WriteLine();

            int yearAfter5Years = DateTime.Now.Year - 5;

            string albumsQuery =
                "/catalog/album[year <= " + yearAfter5Years + "]";

            XmlNodeList albumsList = xmlDoc.SelectNodes(albumsQuery);

            foreach (XmlNode album in albumsList)
            {
                Console.WriteLine("Album: {0}, Price: {1}", 
                    album["name"].InnerText, album["price"].InnerText);
            }
        }
    }
}
