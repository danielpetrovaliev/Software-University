// Easy way to select from XmlDocument => doc.XPathSelectElements("queries/query")

static void Main(string[] args)
{
	XDocument doc = XDocument.Load("../../../files-for-import/rivers.xml");

	var rivers =
		doc.Descendants("river")
			.Select(r => new
			{
				Name = r.Element("name").Value,
				Length = r.Element("length").Value,
				Outflow = r.Element("outflow").Value,
				DrainageArea =
					(r.Element("drainage-area") != null ? r.Element("drainage-area").Value : null),
				AverageDischarge =
					(r.Element("average-discharge") != null ? r.Element("average-discharge").Value : null),
				Countries =
					(r.Element("countries") != null ?
						r.Element("countries")
						.Elements("country")
						.Select(c => c.Value)
						.ToList() :
						null)
			});

	foreach (var river in rivers)
	{
		using (var georgaphyEntities = new GeographyEntities())
		{
			var newRiver = new River
			{
				RiverName = river.Name,
				Length = int.Parse(river.Length),
				Outflow = river.Outflow
			};

			if (river.AverageDischarge != null)
			{
				newRiver.AverageDischarge = int.Parse(river.AverageDischarge);
			}
			if (river.DrainageArea != null)
			{
				newRiver.DrainageArea = int.Parse(river.DrainageArea);
			}

			if (river.Countries != null)
			{
				foreach (var country in river.Countries)
				{
					var existCountry = georgaphyEntities.Countries.FirstOrDefault(c => c.CountryName == country);

					if (existCountry != null)
					{
						newRiver.Countries.Add(existCountry);
					}
				}
			}

			georgaphyEntities.Rivers.Add(newRiver);
			georgaphyEntities.SaveChanges();
		}
	}

}