CREATE FUNCTION dbo.udf_checkIfInputIsComposedFromSetOfLetters
(
        @INPUT NVARCHAR(MAX),
        @SetOfLetters NVARCHAR(MAX)
)
RETURNS BIT
AS BEGIN
        DECLARE @i INT = 1;
        WHILE (@i <= LEN(@INPUT))
        BEGIN
        IF ( @SetOfLetters NOT LIKE '%' + SUBSTRING(@INPUT, @i, 1) + '%' ) BEGIN  
                RETURN 0
        END
        SET @i = @i + 1
    END
        RETURN 1
END
GO
 
--Test the function
DECLARE @SetOfLetters NVARCHAR(50) = 'oistmiahf'
 
SELECT FirstName
FROM Employees
WHERE dbo.udf_checkIfInputIsComposedFromSetOfLetters(FirstName, @SetOfLetters) = CAST(1 AS BIT)
 
SELECT MiddleName
FROM Employees
WHERE dbo.udf_checkIfInputIsComposedFromSetOfLetters(FirstName, @SetOfLetters) = CAST(1 AS BIT)
 
SELECT LastName
FROM Employees
WHERE dbo.udf_checkIfInputIsComposedFromSetOfLetters(LastName, @SetOfLetters) = CAST(1 AS BIT)
 
SELECT Name AS [Town Name]
FROM Towns
WHERE dbo.udf_checkIfInputIsComposedFromSetOfLetters(Name, @SetOfLetters) = CAST(1 AS BIT)
 
GO