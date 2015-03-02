USE Forum
GO

-- =======================================================
-- Problem. 10 -----
-- =======================================================

SELECT a.Content AS [Answer Content],
	q.Title AS [Question],
	c.Name AS [Category]
FROM dbo.Answers a
	JOIN dbo.Questions q
		ON q.Id = a.QuestionId
	JOIN dbo.Categories c
		ON c.Id = q.CategoryId
WHERE a.IsHidden = 1
	AND (	(DATEPART(MONTH, a.CreatedOn) = 
				(SELECT MAX( DATEPART(MONTH, inA.CreatedOn) )
				FROM dbo.Answers inA
				WHERE DATEPART(YEAR, inA.CreatedOn) = (SELECT MAX( DATEPART(YEAR, CreatedOn) ) FROM dbo.Answers) )
			AND DATEPART(YEAR, a.CreatedOn) = 
				(SELECT MAX( DATEPART(YEAR, inA.CreatedOn) )
				FROM dbo.Answers inA)
			)

	OR		(DATEPART(MONTH, a.CreatedOn) = 
				(SELECT MIN( DATEPART(MONTH, inA.CreatedOn) )
				FROM dbo.Answers inA
				WHERE DATEPART(YEAR, inA.CreatedOn) = (SELECT MAX( DATEPART(YEAR, CreatedOn) ) FROM dbo.Answers) )
			AND DATEPART(YEAR, a.CreatedOn) = 
				(SELECT MAX( DATEPART(YEAR, inA.CreatedOn) )
				FROM dbo.Answers inA )
			)
		)
ORDER BY c.Name

-- =======================================================
-- Problem. 13 -----
-- =======================================================

------ 1
CREATE TABLE Towns(
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL
)
GO

ALTER TABLE dbo.Users
ADD TownId INT, 
CONSTRAINT FK_Users_Towns FOREIGN KEY(TownId)
	REFERENCES dbo.Towns(Id)
GO

------ 2
INSERT INTO Towns(Name) VALUES ('Sofia'), ('Berlin'), ('Lyon')
UPDATE Users SET TownId = (SELECT Id FROM Towns WHERE Name='Sofia')
INSERT INTO Towns VALUES
('Munich'), ('Frankfurt'), ('Varna'), ('Hamburg'), ('Paris'), ('Lom'), ('Nantes')

------ 3
UPDATE dbo.Users
SET TownId = (SELECT Id FROM dbo.Towns WHERE Name = 'Paris')
WHERE DATENAME(dw, RegistrationDate) = 'Friday'

------ 4
UPDATE dbo.Answers
SET QuestionId = (SELECT Id FROM dbo.Questions WHERE Title = 'Java += operator')
WHERE DATENAME(month, CreatedOn) = 'February'
	AND (
		DATENAME(dw, CreatedOn) = 'Monday'
		OR DATENAME(dw, CreatedOn) = 'Sunday'
	)

------ 5
CREATE TABLE [#AnswerIds](
	AnswerId INT NOT NULL PRIMARY KEY
)
GO

INSERT INTO #AnswerIds
        ( AnswerId )
SELECT a.Id
FROM dbo.Votes v
JOIN dbo.Answers a
	ON a.Id = v.AnswerId
GROUP BY a.Id
HAVING SUM(v.Value) < 0
GO

DELETE v
FROM dbo.Votes v
WHERE v.AnswerId IN 
	(SELECT a.Id
	FROM dbo.Votes v
	JOIN dbo.Answers a
		ON a.Id = v.AnswerId
	GROUP BY a.Id
	HAVING SUM(v.Value) < 0 )
GO

DELETE a
FROM dbo.Answers a
WHERE a.Id IN (SELECT AnswerId FROM #AnswerIds)
GO

DROP TABLE #AnswerIds
GO

------ 6
INSERT INTO dbo.Questions	
        ( Title ,
          Content ,
          CategoryId ,
          UserId ,
          CreatedOn
        )
VALUES  ( N'Fetch NULL values in PDO query' , -- Title - nvarchar(100)
          'When I run the snippet, NULL values are converted to empty strings. How can fetch NULL values?' , -- Content - ntext
          (SELECT c.Id FROM dbo.Categories c WHERE c.Name = 'Databases') , -- CategoryId - int
          (SELECT u.Id FROM dbo.Users u WHERE u.Username = 'darkcat'), -- UserId - int
          GETDATE()  -- CreatedOn - datetime
        )
GO

------ 7
SELECT t.Name AS [Town], 
	u.Username AS [Username],
	COUNT(a.Id) AS [AnswersCount]
FROM dbo.Towns t
	FULL JOIN dbo.Users u
		ON u.TownId = t.Id
	FULL JOIN dbo.Answers a
		ON a.UserId = u.Id
GROUP BY t.Name, u.Username 
ORDER BY COUNT(a.Id) DESC, u.Username 

-- =======================================================
-- Problem. 13 -----
-- =======================================================

------ 1 
CREATE VIEW AllQuestions
AS
	SELECT u.Id AS [UId],
		u.Username AS [Username],
		u.FirstName,
		u.LastName,
		u.Email,
		u.PhoneNumber,
		u.RegistrationDate,
		q.Id AS [QId],
		q.Title,
		q.Content,
		q.CategoryId,
		q.UserId,
		q.CreatedOn
	FROM dbo.Questions q
		RIGHT JOIN dbo.Users u
			ON u.Id = q.UserId
GO

------ 2
DROP FUNCTION fn_ListUsersQuestions
CREATE FUNCTION fn_ListUsersQuestions()
	RETURNS @table TABLE
		(
			UserName NVARCHAR(100),
			Questions NVARCHAR(MAX)
		)
AS
BEGIN
	-----------------------
	DECLARE @username NVARCHAR(100)

	DECLARE MY_CURSOR CURSOR FOR 
		SELECT DISTINCT Username  
		FROM dbo.AllQuestions
		ORDER BY Username ASC
	OPEN MY_CURSOR
	FETCH NEXT FROM MY_CURSOR INTO @username
	WHILE @@FETCH_STATUS = 0
	BEGIN 
		DECLARE @questions NVARCHAR(MAX)
		SET @questions = (SELECT Stuff( (SELECT N', ' + Title FROM dbo.AllQuestions WHERE Username = @username ORDER BY Title DESC FOR XML PATH(''),TYPE).value('text()[1]','nvarchar(max)'),1,2,N''))
			
		INSERT INTO @table(UserName, Questions)
		VALUES (@username, @questions)

		FETCH NEXT FROM MY_CURSOR INTO @username
	END
	CLOSE MY_CURSOR
	DEALLOCATE MY_CURSOR
	-----------------------
	
	RETURN;
END;
GO 

SELECT * FROM fn_ListUsersQuestions()