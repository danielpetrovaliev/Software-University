USE Ads
GO

-- ====================================================================================================
-- Problem 1.	All Ad Titles
-- Display all ad titles in ascending order. Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	Title
FROM dbo.Ads
ORDER BY Title ASC

-- ====================================================================================================
-- Problem 2.	Ads in Date Range
-- Find all ads created between 26-December-2014 (00:00:00) and 1-January-2015 (23:59:59) 
-- sorted by date. Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	Title,
	Date
FROM dbo.Ads
WHERE Date BETWEEN '2014/12/26' AND '2015/01/02'
ORDER BY Date

-- ====================================================================================================
-- Problem 3.	* Ads with "Yes/No" Images
-- Display all ad titles and dates along with a column named "Has Image" holding "yes" or "no" 
-- FOR all ads sorted by their Id. Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	Title,
	Date,
	[Has Image] =
					CASE
						WHEN ImageDataURL IS NULL THEN 'yes'
						WHEN ImageDataURL IS NOT NULL THEN 'no'
					END
FROM dbo.Ads

-- ====================================================================================================
-- Problem 4.	Ads without Town, Category or Image
-- Find all ads that have no town, no category or no image sorted by Id. Show all their data.
-- Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	*
FROM dbo.Ads
WHERE TownId IS NULL
OR CategoryId IS NULL
OR ImageDataURL IS NULL

-- ====================================================================================================
-- Problem 5.	Ads with Their Town
-- Find all ads along with their towns sorted by Id. Display the ad title and town (even when there is no town). 
-- Name the columns exactly like in the table below. Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	a.Title,
	t.Name AS [Town]
FROM dbo.Ads a
LEFT JOIN dbo.Towns t
	ON t.Id = a.TownId

-- ====================================================================================================
-- Problem 6.	Ads with Their Category, Town and Status
-- Find all ads along with their categories, towns and statuses sorted by Id. 
-- Display the ad title, category name, town name and status.
-- Name the columns exactly like in the table below.
-- Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	a.Title,
	c.Name AS [CategoryName],
	t.Name AS [TownName],
	s.Status
FROM dbo.Ads a
LEFT JOIN dbo.Categories c
	ON c.Id = a.CategoryId
LEFT JOIN dbo.Towns t
	ON t.Id = a.TownId
LEFT JOIN dbo.AdStatuses s
	ON s.Id = a.StatusId

-- ====================================================================================================
-- Problem 7.	Filtered Ads with Category, Town and Status
-- Find all Published ads from Sofia, Blagoevgrad or Stara Zagora, along with their category,
-- town and status sorted by title. Display the ad title, category name, town name and status.
-- Name the columns exactly like in the table below. Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	a.Title,
	c.Name AS [CategoryName],
	t.Name AS [TownName],
	s.Status
FROM dbo.Ads a
JOIN dbo.Categories c
	ON c.Id = a.CategoryId
JOIN dbo.Towns t
	ON t.Id = a.TownId
JOIN dbo.AdStatuses s
	ON s.Id = a.StatusId
WHERE s.Status = 'Published'
AND t.Name IN ('Sofia', 'Blagoevgrad', 'Stara Zagora')
ORDER BY a.Title

-- ====================================================================================================
-- Problem 8.	Earliest and Latest Ads
-- Find the dates of the earliest and the latest published ads
-- Name the columns exactly like in the table below.
-- Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	MIN(Date) AS [MinDate],
	MAX(Date) AS [MaxDate]
FROM dbo.Ads

-- ====================================================================================================
-- Problem 9.	Latest 10 Ads
-- Find the latest 10 ads sorted by date in descending order. Display for each ad its title, date and status.
-- Name the columns exactly like in the table below. Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT TOP 10
	a.Title,
	a.Date,
	s.Status
FROM dbo.Ads a
JOIN dbo.AdStatuses s
	ON s.Id = a.StatusId
ORDER BY a.Date DESC

-- ====================================================================================================
-- Problem 10.	Not Published Ads from the First Month
-- Find all not published ads, created in the same month and year like the earliest ad.
-- Display for each ad its id, title, date and status. Sort the results by Id.
-- Name the columns exactly like in the table below. Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	a.Id,
	a.Title,
	a.Date,
	s.Status
FROM dbo.Ads a
JOIN dbo.AdStatuses s
	ON s.Id = a.StatusId
WHERE DATEPART(YEAR, a.Date) = (SELECT
	DATEPART(YEAR, MIN(Date))
FROM dbo.Ads)
AND DATEPART(MONTH, a.Date) = (SELECT
	DATEPART(MONTH, MIN(Date))
FROM dbo.Ads)
AND s.Status IN ('Waiting Approval', 'Inactive')

-- ====================================================================================================
-- Problem 11.	Ads by Status
-- Display the count of ads in each status. Sort the results by status. 
-- Name the columns exactly like in the table below. Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	s.Status,
	COUNT(a.Id) AS [Count]
FROM dbo.Ads a
JOIN dbo.AdStatuses s
	ON s.Id = a.StatusId
GROUP BY s.Status
ORDER BY s.Status

-- ====================================================================================================
-- Problem 12.	Ads by Town and Status
-- Display the count of ads for each town and each status. Sort the results by town, then by status.
-- Display only non-zero counts.
-- Name the columns exactly like in the table below. Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	t.Name AS [Town Name],
	s.Status AS [Status],
	COUNT(a.Id) AS [Count]
FROM dbo.Ads a
JOIN dbo.AdStatuses s
	ON s.Id = a.StatusId
JOIN dbo.Towns t
	ON t.Id = a.TownId
GROUP BY	t.Name,
			s.Status
ORDER BY t.Name,
s.Status

-- ====================================================================================================
-- Problem 13.	* Ads by Users
-- Find the count of ads for each user. Display the username, ads count and "yes" or "no"
-- depending on whether the user belongs to the role "Administrator". Sort the results by username.
-- Sort the results by username. Display all users, including the users who have no ads.
-- Name the columns exactly like in the table below. Submit for evaluation the result grid with headers.
-- ====================================================================================================
-- TODO://
SELECT  u.UserName ,
        COUNT(a.Id) AS [AdsCount] ,
        ( CASE WHEN u.UserName IN (
                    SELECT  u.UserName
                    FROM    dbo.AspNetUsers u
                            JOIN dbo.AspNetUserRoles ur ON ur.UserId = u.Id
                            JOIN dbo.AspNetRoles r ON r.Id = ur.RoleId
                    WHERE   r.Name = 'Administrator' ) THEN 'yes'
               ELSE 'no'
          END ) AS [IsAdministrator]
FROM    dbo.AspNetUsers u
        LEFT JOIN dbo.Ads a ON a.OwnerId = u.Id
GROUP BY u.UserName
ORDER BY u.UserName

-- ====================================================================================================
-- Problem 14.	Ads by Town
-- Find the count of ads for each town. Display the ads count and town name or "(no town)"
-- for the ads without a town. Display only the towns, which hold 2 or 3 ads.
-- Sort the results by town name. 
-- Name the columns exactly like in the table below. Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	COUNT(a.Id) AS [AdsCount],
	[Town] =
			CASE
				WHEN t.Name IS NULL THEN '(no town)'
				ELSE t.Name
			END
FROM dbo.Ads a
LEFT JOIN dbo.Towns t
	ON t.Id = a.TownId
GROUP BY t.Name
HAVING COUNT(a.Id) = 2
OR COUNT(a.Id) = 3
ORDER BY t.Name

-- ====================================================================================================
-- Problem 15.	Pairs of Dates within 12 Hours
-- Consider the dates of the ads. Find among them all pairs of different dates,
-- such that the second date is no later than 12 hours after the first date. 
-- Sort the dates in increasing order by the first date, then by the second date.
-- Name the columns exactly like in the table below. Submit for evaluation the result grid with headers.
-- ====================================================================================================

SELECT
	a1.Date AS FirstDate,
	a2.Date AS SecondDate
FROM	dbo.Ads a1,
		dbo.Ads a2
WHERE a1.Date < a2.Date
AND a2.Date <= DATEADD(HOUR, 12, a1.Date)
ORDER BY a1.Date,
a2.Date

SELECT
	a1.Date AS FirstDate,
	a2.Date AS SecondDate
FROM	Ads a1,
		Ads a2
WHERE a2.Date > a1.Date
AND DATEDIFF(SECOND, a1.Date, a2.Date) < 12 * 60 * 60
ORDER BY a1.Date,
a2.Date

-- =============================================================
-- Problem 16.	Ads by Country
-- =============================================================

-- 1

IF OBJECT_ID('dbo.Countries') IS NOT NULL
DROP TABLE dbo.Countries

CREATE TABLE Countries
    (
      Id INT NOT NULL
             IDENTITY ,
      Name NVARCHAR(50) NOT NULL ,
      CONSTRAINT PK_Id PRIMARY KEY ( Id )
    )
GO

ALTER TABLE dbo.Towns
ADD CountryId INT
GO

ALTER TABLE dbo.Towns
ADD CONSTRAINT FK_Towns_Coutries FOREIGN KEY(CountryId)
REFERENCES dbo.Countries(Id)
GO

-- 2 =========================================================

INSERT INTO Countries (Name)
	VALUES ('Bulgaria'),
	('Germany'),
	('France')
UPDATE Towns
SET CountryId = (SELECT
	Id
FROM Countries
WHERE Name = 'Bulgaria')
INSERT INTO Towns
	VALUES ('Munich', (SELECT Id FROM Countries WHERE Name = 'Germany')),
	('Frankfurt', (SELECT Id FROM Countries WHERE Name = 'Germany')),
	('Berlin', (SELECT Id FROM Countries WHERE Name = 'Germany')),
	('Hamburg', (SELECT Id FROM Countries WHERE Name = 'Germany')),
	('Paris', (SELECT Id FROM Countries WHERE Name = 'France')),
	('Lyon', (SELECT Id FROM Countries WHERE Name = 'France')),
	('Nantes', (SELECT Id FROM Countries WHERE Name = 'France'))

-- 3 =========================================================

UPDATE dbo.Ads
SET TownId = (SELECT
	Id
FROM dbo.Towns
WHERE Name = 'Paris')
WHERE DATENAME(dw, Date) = 'Friday'

-- 4 =========================================================

UPDATE dbo.Ads
SET TownId = (SELECT
	Id
FROM dbo.Towns
WHERE Name = 'Hamburg')
WHERE DATENAME(dw, Date) = 'Thursday'

-- 5 =========================================================

DELETE FROM dbo.Ads
WHERE Id IN (SELECT
		a.Id
	FROM dbo.Ads a
	JOIN dbo.AspNetUsers u
		ON u.Id = a.OwnerId
	JOIN dbo.AspNetUserRoles ur
		ON ur.UserId = u.Id
	JOIN dbo.AspNetRoles r
		ON r.Id = ur.RoleId
	WHERE r.Name = 'Partner')

-- 6 =========================================================

INSERT INTO dbo.Ads (Title,
Text,
OwnerId,
Date,
StatusId)
	VALUES ('Free Book', -- Title - nvarchar(max)
	'Free C# Book', -- Text - nvarchar(max)
	(SELECT u.Id FROM dbo.AspNetUsers u WHERE u.UserName = 'nakov'), GETDATE(), -- Date - datetime
	(SELECT s.Id FROM dbo.AdStatuses s WHERE s.Status = 'Waiting Approval'))

-- 7 =========================================================
SELECT
	t.Name AS Town,
	c.Name AS Country,
	COUNT(a.Id) AS AdsCount
FROM dbo.Towns t
FULL JOIN dbo.Ads a
	ON a.TownId = t.Id
FULL JOIN dbo.Countries c
	ON t.CountryId = c.Id
GROUP BY	t.Id,
			t.Name,
			c.Id,
			c.Name
ORDER BY t.Name, c.Name

-- =====================================================================
-- Problem 17.	Create a View and a Stored Function
-- =====================================================================

-- 1 =================

IF (object_id(N'dbo.AllAds') IS NOT NULL)
DROP VIEW dbo.AllAds
GO

CREATE VIEW AllAds
AS
	SELECT a.Id,
		a.Title,
		u.UserName AS [Author],
		a.Date,
		t.Name AS [Town],
		c.Name AS [Category],
		s.Status
	FROM dbo.Ads a
		FULL JOIN dbo.AspNetUsers u
			ON u.Id = a.OwnerId
		LEFT JOIN dbo.Categories c
			ON c.Id = a.CategoryId
		LEFT JOIN dbo.AdStatuses s
			ON s.Id = a.StatusId
		LEFT JOIN dbo.Towns t
			ON t.Id = a.TownId
GO

SELECT * FROM AllAds
GO

-- 2 ==================

IF (object_id(N'fn_ListUsersAds') IS NOT NULL)
DROP FUNCTION fn_ListUsersAds
GO

CREATE FUNCTION fn_ListUsersAds()
	RETURNS @table TABLE
		(
			UserName NVARCHAR(100),
			AdDates NVARCHAR(MAX)
		)
AS
BEGIN
	-----------------------
	DECLARE @username NVARCHAR(100)

	DECLARE MY_CURSOR CURSOR FOR 
		SELECT DISTINCT Author  
		FROM dbo.AllAds
		ORDER BY Author DESC
	OPEN MY_CURSOR
	FETCH NEXT FROM MY_CURSOR INTO @username
	WHILE @@FETCH_STATUS = 0
	BEGIN 
		DECLARE @dates NVARCHAR(MAX)
		SET @dates = (SELECT Stuff( (SELECT N'; ' + FORMAT(Date, 'yyyyMMdd') FROM dbo.AllAds WHERE Author = @username ORDER BY Date ASC FOR XML PATH(''),TYPE).value('text()[1]','nvarchar(max)'),1,2,N''))
			
		INSERT INTO @table(UserName, AdDates)
		VALUES (@username, @dates)

		FETCH NEXT FROM MY_CURSOR INTO @username
	END
	CLOSE MY_CURSOR
	DEALLOCATE MY_CURSOR
	-----------------------
	
	RETURN;
END;
GO 

SELECT * FROM dbo.fn_ListUsersAds()
