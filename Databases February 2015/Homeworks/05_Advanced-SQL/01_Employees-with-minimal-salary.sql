SELECT FirstName, LastName, Salary
FROM Employees e
WHERE Salary = 
	(SELECT MIN(Salary) From Employees)