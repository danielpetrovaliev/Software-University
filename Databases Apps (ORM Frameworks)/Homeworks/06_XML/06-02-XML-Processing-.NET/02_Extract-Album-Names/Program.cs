using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02_Extract_Album_Names
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

            foreach (XmlNode albumNode in rootNode.ChildNodes)
            {
                Console.WriteLine("Album: {0}", albumNode["name"].InnerText);
            }
        }
    }
}
