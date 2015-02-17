USE SoftUni
GO

INSERT INTO Users(UserName, Password, FullName, GroupID)
SELECT LOWER(LEFT(FirstName, 3) + LastName), 
	LOWER(LEFT(FirstName, 3) + LastName),
	FirstName + LastName as FullName,
	6
FROM Employees
