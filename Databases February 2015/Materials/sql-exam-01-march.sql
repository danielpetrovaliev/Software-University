-- ===================================================
-- Problem 1.	All Mountain Peaks
-- Display all ad mountain peaks in alphabetical order. 
-- Submit for evaluation the result grid with headers.
-- ===================================================

SELECT p.PeakName
FROM dbo.Peaks p
ORDER BY p.PeakName

-- =============================================================
--Problem 2.	Biggest Countries by POPULATION
--Find the 30 biggest countries by population from Europe. 
--Display the country name and population.
--Sort the results by population (from biggest to smallest), 
--then by country alphabetically. Submit for evaluation the
--result grid with headers.
-- =============================================================

SELECT TOP 30 c.CountryName, c.Population
FROM dbo.Countries c
	JOIN dbo.Continents con
		ON con.ContinentCode = c.ContinentCode
WHERE c.ContinentCode = 
	(SELECT ContinentCode FROM dbo.Continents WHERE ContinentName = 'Europe')
ORDER BY c.Population DESC, c.CountryName ASC 

-- =============================================================
-- Problem 3.	Countries and Currency (Euro / Not Euro)
--Find all countries along with information about their currency. 
--Display the country code, country name and information about 
--its currency: either "Euro" or "Not Euro". Sort the results by 
--country name alphabetically. Submit for evaluation 
--the result grid with headers.
-- =============================================================

SELECT 
	CountryName,
	CountryCode,
	[Currency] =
	CASE
		WHEN CurrencyCode = 'EUR' THEN 'Euro'
		ELSE 'Not Euro'
	END
FROM dbo.Countries
ORDER BY CountryName ASC

-- =============================================================
-- Problem 4.	Countries Holding 'A' 3 or More Times
--Find all countries that holds the letter 'A' in their name 
--at least 3 times (case insensitively), sorted by ISO code. 
--Display the country name and ISO code. Submit for evaluation 
--the result grid with headers.
-- =============================================================

SELECT c.CountryName AS [Country Name],
 c.IsoCode AS [ISO Code]
FROM dbo.Countries c
WHERE c.CountryName LIKE '%A%A%A%'
ORDER BY c.IsoCode

-- =============================================================
-- Problem 5.	Peaks and Mountains
--Find all peaks along with their mountain sorted by 
--elevation (from the highest to the lowest), then by peak 
--name alphabetically. Display the peak name, mountain range 
--name and elevation. Submit for evaluation the result grid with headers.
-- =============================================================

SELECT p.PeakName, 
	m.MountainRange AS [Mountain],
	p.Elevation
FROM dbo.Peaks p
	JOIN dbo.Mountains m
		ON m.Id = p.MountainId
ORDER BY p.Elevation DESC

-- =============================================================
-- Problem 6.	Peaks with Their Mountain, Country and Continent
--Find all peaks along with their mountain, 
--country and continent. When a mountain belongs 
--to multiple countries, display them all. 
--Sort the results by peak name alphabetically, then by 
--country name alphabetically. Submit for evaluation the 
--result grid with headers.
-- =============================================================

SELECT p.PeakName,
	m.MountainRange AS [Mountain],
	c.CountryName,
	cont.ContinentName
FROM dbo.Mountains m
	JOIN dbo.MountainsCountries mc 
		ON mc.MountainId = m.Id
	JOIN dbo.Countries c
		ON c.CountryCode = mc.CountryCode
	JOIN dbo.Peaks p 
		ON p.MountainId = m.Id
	JOIN dbo.Continents cont
		ON cont.ContinentCode = c.ContinentCode
ORDER BY p.PeakName ASC, c.CountryName ASC

-- =============================================================
-- Problem 7.	* Rivers Passing through 3 or More Countries
--Find all rivers that pass through to 3 or more countries. 
--Display the river name and the number of countries. 
--Sort the results by river name. Submit for evaluation 
--the result grid with headers.
-- =============================================================

SELECT r.RiverName AS [River],
	COUNT(c.CountryCode) AS [Countries Count]
FROM dbo.Rivers r
	JOIN dbo.CountriesRivers cr
		ON cr.RiverId = r.Id
	JOIN dbo.Countries c
		ON c.CountryCode = cr.CountryCode
GROUP BY r.Id, r.RiverName
HAVING COUNT(c.CountryCode) >= 3
ORDER BY r.RiverName

-- =============================================================
-- Problem 8.	Highest, Lowest and Average Peak Elevation
--Find the highest, lowest and average peak elevation. 
--Submit for evaluation the result grid with headers.
-- =============================================================

SELECT MAX(p.Elevation) AS [MaxElevation],
	MIN(p.Elevation) AS [MinElevation],
	AVG(p.Elevation) AS [AverageElevation]
FROM dbo.Peaks p

-- =============================================================
-- Problem 9.	Rivers by Country
--For each country in the database, display the number of rivers 
--passing through that country and the total length of these rivers.
-- When a country does not have any river, display 0 as rivers count 
-- and as total length. Sort the results by rivers count (from largest
--  to smallest), then by total length (from largest to smallest), 
--  then by country alphabetically. Submit for evaluation the result 
--  grid with headers.
-- =============================================================

SELECT c.CountryName,
	con.ContinentName,
	COUNT(r.Id) AS [RiversCount],
	[TotalLength] =
		CASE 
			WHEN SUM(r.Length) IS NULL THEN 0
			ELSE SUM(r.Length)
		END 
FROM dbo.Countries c
	LEFT JOIN dbo.CountriesRivers cr
		ON cr.CountryCode = c.CountryCode
	FULL JOIN dbo.Rivers r
		ON r.Id = cr.RiverId
	JOIN dbo.Continents con
		ON con.ContinentCode = c.ContinentCode
GROUP BY c.CountryCode, c.CountryName, con.ContinentName
ORDER BY COUNT(r.Id) DESC, SUM(r.Length) DESC, c.CountryName 

-- =============================================================
-- Problem 10.	Count of Countries by Currency
--Find the number of countries for each currency. 
--Display three columns: currency code, currency 
--description and number of countries. Sort the results by 
--number of countries (from highest to lowest), then by 
--currency description alphabetically. Name the columns 
--exactly like in the table below. Submit for evaluation 
--the result grid with headers.
-- =============================================================

SELECT cur.CurrencyCode,
	cur.Description AS [Currency],
	COUNT(contr.CountryCode) AS [NumberOfCountries]
FROM dbo.Countries contr
	RIGHT JOIN dbo.Currencies cur
		ON cur.CurrencyCode = contr.CurrencyCode
GROUP BY cur.CurrencyCode, cur.Description
ORDER BY COUNT(contr.CountryCode) DESC, cur.Description ASC

-- =============================================================
-- Problem 11.	* Population and Area by Continent
--For each continent, display the total area and 
--total population of all its countries. Sort the 
--results by population from highest to lowest. 
--Submit for evaluation the result grid with headers.
-- =============================================================

SELECT cont.ContinentName,
	SUM( CONVERT(BIGINT, countr.AreaInSqKm) ) AS [CountriesArea],
	SUM( CONVERT(BIGINT, countr.Population) ) AS [CountriesPopulation]
FROM dbo.Continents cont
	JOIN dbo.Countries countr
		ON countr.ContinentCode = cont.ContinentCode
GROUP BY cont.ContinentCode, cont.ContinentName
ORDER BY CountriesPopulation DESC

-- =============================================================
-- Problem 12.	Highest Peak and Longest River by Country
-- For each country, find the elevation of the highest peak
-- and the length of the longest river, sorted by the 
-- highest peak elevation (from highest to lowest), 
-- then by the longest river length (from longest to smallest), 
-- then by country name (alphabetically). Display NULL 
-- when no data is available in some of the columns. Submit 
-- FOR evaluation the result grid with headers.
-- =============================================================

SELECT countr.CountryName,
	MAX(p.Elevation) AS [HighestPeakElevation],
	MAX(r.Length) AS [LongestRiverLength]
FROM dbo.Countries countr
	LEFT JOIN dbo.MountainsCountries mc
		ON mc.CountryCode = countr.CountryCode
	FULL JOIN dbo.Mountains m
		ON m.Id = mc.MountainId
	FULL JOIN dbo.Peaks p
		ON p.MountainId = m.Id
	FULL JOIN dbo.CountriesRivers cr
		ON cr.CountryCode = countr.CountryCode
	FULL JOIN dbo.Rivers r
		ON r.Id = cr.RiverId
GROUP BY countr.CountryCode, countr.CountryName
HAVING countr.CountryCode IS NOT NULL
ORDER BY HighestPeakElevation DESC, 
	LongestRiverLength DESC, 
	countr.CountryName ASC

-- =====================================================
-- Problem 13.	Mix of Peak and River Names
-- =====================================================

SELECT p.PeakName,
	r.RiverName,
	LOWER(p.PeakName + SUBSTRING(r.RiverName, 2, LEN(r.RiverName))) AS [Mix]
FROM dbo.Peaks p
	JOIN dbo.Rivers r
		ON LOWER(RIGHT(p.PeakName, 1)) = LOWER(LEFT(r.RiverName, 1))
ORDER BY Mix

-- =====================================================
-- Problem 14.	** Highest Peak Name and Elevation by Country
-- =====================================================

--SELECT countr.CountryName AS [Country],
--	[Highest Peak Name] = 
--		CASE
--			WHEN COUNT(p.Id) = 0 THEN '(no highest peak)'
--			ELSE 
--		END,
--	[Highest Peak Elevation] =
--		CASE 
--			WHEN 
--		END

--FROM dbo.Countries countr
--	FULL JOIN dbo.MountainsCountries mc
--		ON mc.CountryCode = countr.CountryCode
--	FULL JOIN dbo.Mountains m
--		ON m.Id = mc.MountainId
--	FULL JOIN dbo.Peaks p
--		ON p.MountainId = m.Id
--GROUP BY countr.CountryCode, countr.CountryName
--HAVING countr.CountryCode IS NOT NULL


-- =====================================================
-- Problem 15.	Monasteries by Country
-- =====================================================

---------- 1 
USE Geography
GO

CREATE TABLE Monasteries(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name NVARCHAR(max) NOT NULL,
	CountryCode CHAR(2),
	CONSTRAINT FK_Monasteries_Countries FOREIGN KEY(CountryCode)
		REFERENCES dbo.Countries(CountryCode)
)
GO

---------- 2

INSERT INTO Monasteries(Name, CountryCode) VALUES
('Rila Monastery “St. Ivan of Rila”', 'BG'), 
('Bachkovo Monastery “Virgin Mary”', 'BG'),
('Troyan Monastery “Holy Mother''s Assumption”', 'BG'),
('Kopan Monastery', 'NP'),
('Thrangu Tashi Yangtse Monastery', 'NP'),
('Shechen Tennyi Dargyeling Monastery', 'NP'),
('Benchen Monastery', 'NP'),
('Southern Shaolin Monastery', 'CN'),
('Dabei Monastery', 'CN'),
('Wa Sau Toi', 'CN'),
('Lhunshigyia Monastery', 'CN'),
('Rakya Monastery', 'CN'),
('Monasteries of Meteora', 'GR'),
('The Holy Monastery of Stavronikita', 'GR'),
('Taung Kalat Monastery', 'MM'),
('Pa-Auk Forest Monastery', 'MM'),
('Taktsang Palphug Monastery', 'BT'),
('Sümela Monastery', 'TR')

---------- 3

ALTER TABLE dbo.Countries
ADD IsDeleted BIT NOT NULL DEFAULT 0
GO

----------- 4

UPDATE dbo.Countries
SET IsDeleted = 1
WHERE CountryName IN (
	SELECT c.CountryName
	FROM dbo.Countries c
		FULL JOIN dbo.CountriesRivers cr
			ON cr.CountryCode = c.CountryCode
		FULL JOIN dbo.Rivers r
			ON r.Id = cr.RiverId
	GROUP BY c.CountryCode, c.CountryName
	HAVING COUNT(r.Id) > 3
	)
GO

--------- 5

SELECT m.Name AS [Monastery],
	c.CountryName AS [Country]	
FROM dbo.Countries c
JOIN dbo.Monasteries m
	ON m.CountryCode = c.CountryCode
WHERE c.IsDeleted = 0
ORDER BY m.Name

-- =====================================================
-- Problem 16.	Monasteries by Continents and Countries
-- =====================================================

-------- 1

UPDATE dbo.Countries
SET CountryName = 'Burma'
WHERE CountryName = 'Myanmar'
GO

-------- 2, 3

INSERT INTO dbo.Monasteries
        ( Name, CountryCode )
VALUES  ( N'Hanga Abbey', -- Name - nvarchar(max)
          (SELECT CountryCode FROM dbo.Countries WHERE CountryName = 'Tanzania')  -- CountryCode - char(2)
          ),
		  ( N'Myin-Tin-Daik', -- Name - nvarchar(max)
          (SELECT CountryCode FROM dbo.Countries WHERE CountryName = 'Myanmar')  -- CountryCode - char(2)
          )

------- 4

SELECT cont.ContinentName, 
	countr.CountryName,
	COUNT(m.Id) AS [MonasteriesCount] 
FROM dbo.Countries countr
	FULL JOIN dbo.Continents cont
		ON cont.ContinentCode = countr.ContinentCode
	FULL JOIN dbo.Monasteries m
		ON m.CountryCode = countr.CountryCode
WHERE countr.IsDeleted = 0
GROUP BY cont.ContinentCode, 
	cont.ContinentName, 
	countr.CountryCode, 
	countr.CountryName
ORDER BY MonasteriesCount DESC, countr.CountryName
GO

-- =====================================================
-- Problem 17.	Stored Function: Mountain Peaks JSON
-- =====================================================

DROP FUNCTION dbo.fn_MountainsPeaksJSON
CREATE FUNCTION dbo.fn_MountainsPeaksJSON()
	RETURNS nvarchar(max)
AS
BEGIN
	DECLARE @result NVARCHAR(max);

	SET @result = '{"mountains":[';

	----------------------------------------
	DECLARE @mauntainName NVARCHAR(max);

	DECLARE MY_CURSOR CURSOR FOR 
		SELECT MountainRange 
		FROM dbo.Mountains
	OPEN MY_CURSOR
	FETCH NEXT FROM MY_CURSOR INTO @mauntainName
	WHILE @@FETCH_STATUS = 0
	BEGIN 
		DECLARE @mauntain NVARCHAR(max);
		DECLARE @peaks NVARCHAR(max);
		SET @mauntain = (select STUFF((
			select 
				', {"name":"' + @mauntainName + '"'
				+ ',"peaks":' + ISNULL( ( select '[' + STUFF((select ',{"name":"' + PeakName + '"' + ',"elevation":' + cast(Elevation as varchar(max)) +'}'  from dbo.Peaks RIGHT JOIN dbo.Mountains ON Mountains.Id = Peaks.MountainId WHERE MountainRange = @mauntainName for xml path(''), type ).value('.', 'varchar(max)'), 1, 1, '') + ']' ), '[]' )
				+'}'
			for xml path(''), type
			).value('.', 'varchar(max)'), 1, 2, '') + ',')
		
		SET @result = @result + ISNULL(@mauntain, '')
		FETCH NEXT FROM MY_CURSOR INTO @mauntainName
	END
	CLOSE MY_CURSOR
	DEALLOCATE MY_CURSOR


	----------------------------------------
	
	SET @result = SUBSTRING(@result, 0, LEN(@result));
	SET @result = @result + ']}';
	RETURN @result;
END

SELECT dbo.fn_MountainsPeaksJSON();


-- ============================================================
-- Problem 18.	Design a Database Schema in MySQL and Write a Query
-- ============================================================

CREATE SCHEMA `trainings` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci ;

CREATE TABLE `training_centers` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(500) NULL,
  `URL` VARCHAR(100) NULL,
  PRIMARY KEY (`id`));

  
  CREATE TABLE `timetable` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `course_id` INT NOT NULL,
  `training_center_id` INT NOT NULL,
  `start_date` DATE NOT NULL,
  PRIMARY KEY (`id`));
  
  CREATE TABLE `trainings`.`courses` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  `description` VARCHAR(500) NULL,
  PRIMARY KEY (`id`));

  
  
  select tc.name as `training center`,
	tt.start_date as `start date`,
    c.name as `course name`,
    (c.description) as `more info`
from timetable tt
	join courses c
		on c.id = tt.course_id
	join training_centers tc
		on tc.id = tt.training_center_id
order by tt.start_date

