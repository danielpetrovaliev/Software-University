using System.Xml.Linq;
using System.Xml.XPath;
using Football.Data;

namespace Generate_Random_Matches
{
    class Program
    {
        private const string DocumentPath = "../../../Files-for-Import/generate-matches.xml";

        static void Main(string[] args)
        {
            var doc = XDocument.Load(DocumentPath);

            // TODO
        }
    }
}
