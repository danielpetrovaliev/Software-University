static void Main(string[] args)
{
	string jsonAsString = File.ReadAllText(@"../../../files-for-import/mountains.json");

	var mountainsFromJson = JArray.Parse(jsonAsString);

	foreach (var mountain in mountainsFromJson)
	{
		try
		{
			ImportMountain(mountain);
			Console.WriteLine("Mountain {0} was added to db.", mountain["mountainName"]);
		}
		catch (Exception e)
		{
			Console.WriteLine("Exception: " + e.Message);
		}
	}

}

private static void ImportMountain(JToken mountain)
{
	using (var context = new GeographyCodeFirstDbContext())
	{
		var newMountain = new Mountain();

		if (mountain["mountainName"] == null)
		{
			throw new ArgumentException("Missing Mountain name.");
		}

		newMountain.Name = mountain["mountainName"].Value<string>();

		if (mountain["peaks"] != null)
		{
			var peaks = mountain["peaks"];

			foreach (var peak in peaks)
			{
				if (peak["peakName"] == null)
				{
					throw new ArgumentException("Missing peak name.");        
				}
				if (peak["elevation"] == null)
				{
					throw new ArgumentException("Missing peak elevation.");        
				}

				var newPeak = new Peak
				{
					Elevation = peak["elevation"].Value<int>(),
					PeakName = peak["peakName"].Value<string>()
				};

				newMountain.Peaks.Add(newPeak);
			}
		}

		if (mountain["countries"] != null)
		{
			var countrieNames = mountain["countries"];

			foreach (var countryName in countrieNames)
			{
				var newCountry = new Country
				{
					CountryName = countryName.Value<string>(),
					CountryCode = new string(countryName.Value<string>().Take(2).ToArray()).ToUpper()
				};

				newMountain.Countries.Add(newCountry);
			}
		}

		context.Mountains.Add(newMountain);
		context.SaveChanges();
	}
}