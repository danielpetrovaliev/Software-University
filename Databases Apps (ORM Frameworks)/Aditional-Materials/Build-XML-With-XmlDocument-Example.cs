static void Main(string[] args)
{
	XmlDocument doc = new XmlDocument();
	doc.AppendChild(doc.CreateXmlDeclaration("1.0", null, null));

	XmlElement rootNode = doc.CreateElement("monasteries");

	using (var georgraphyEntities = new GeographyEntities())
	{
		var countriesWithMonasteries = georgraphyEntities
			.Countries
			.Include(c => c.Monasteries)
			.Where(c => c.Monasteries.Any())
			.OrderBy(c => c.CountryName)
			.Select(c => new {CountryName = c.CountryName, Monasteries = c.Monasteries.OrderBy(m => m.Name)});

		foreach (var country in countriesWithMonasteries)
		{
			XmlElement countryNode = doc.CreateElement("country");
			countryNode.SetAttribute("name", country.CountryName); 

			foreach (var monastery in country.Monasteries)
			{
				XmlElement monasteryNode = doc.CreateElement("monastery");
				monasteryNode.InnerText = monastery.Name;

				countryNode.AppendChild(monasteryNode);
			}

			rootNode.AppendChild(countryNode);
		}

		doc.AppendChild(rootNode);
	}

	doc.Save("../../../generated-files/02_Monasteries-by-Country.xml");
}