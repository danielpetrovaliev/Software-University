using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _08_XML_LINQ_Old_Albums
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xmlDoc = XDocument.Load("../../../01_Musical-Albums-in-XML.xml");

            Console.WriteLine("XML Document loaded !");
            Console.WriteLine();

            var oldAlbums =
                (from album in xmlDoc.Descendants("album")
                    where Decimal.Parse(album.Element("year").Value) <= (DateTime.Now.Year - 5)
                    select new
                    {
                        Name = album.Element("name").Value,
                        Price = album.Element("price").Value
                    }
                ).ToList();

            foreach (var album in oldAlbums)
            {
                Console.WriteLine("Album: {0}, Price: {1}", album.Name, album.Price);
            }

        }
    }
}
