using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace _09_Directories_as_XML
{
    class Program
    {
        static void Main()
        {
            string rootDir = "../../../folder";

            XmlDocument doc = new XmlDocument();

            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);

            XmlElement root = doc.CreateElement("root-dir");
            root.SetAttribute("path", GetFileOrFolderName(rootDir));

            doc.AppendChild(root);

            GenerateXmlForDirectories(rootDir, doc, "root-dir");

            doc.Save("../../../new.xml");
            Console.WriteLine("All is done.");
        }

        static void GenerateXmlForDirectories(string path, XmlDocument doc, string folderName, bool isFirstTime = true)
        {
            string[] files;
            string[] directories;

            files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                string fileName = GetFileOrFolderName(file);

                string folderQuery = "//dir[@name = \"" + folderName +"\" ]";

                if (isFirstTime)
                {
                    folderQuery = "root-dir";
                }

                XmlNode currFolderNode = doc.SelectSingleNode(folderQuery);

                XmlElement newElement = doc.CreateElement("file");
                newElement.SetAttribute("name", fileName);

                currFolderNode.AppendChild(newElement);
            }


            directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                var directoryName = GetFileOrFolderName(directory);

                string folderQuery = "//dir[@name = \"" + folderName + "\" ]";
                if (isFirstTime)
                {
                    folderQuery = "root-dir";
                }

                XmlNode currFolderNode = doc.SelectSingleNode(folderQuery);

                XmlElement newElement = doc.CreateElement("dir");
                newElement.SetAttribute("name", directoryName);

                currFolderNode.AppendChild(newElement);

                GenerateXmlForDirectories(directory, doc, directoryName, false);
            }
        }

        static string GetFileOrFolderName(string entityName)
        {
            Regex titleRegex = new Regex(@"[^\\]*$", RegexOptions.IgnoreCase);

            var matches = titleRegex.Matches(entityName);

            string matchedName = matches.Cast<object>()
                .Aggregate("", (current, match) => current + match);

            return matchedName;
        }
    }
}
