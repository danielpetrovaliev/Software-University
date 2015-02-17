SELECT FirstName, LastName, Salary
FROM Employees e
WHERE Salary <=
	(SELECT MIN(Salary) From Employees) * 0.10 +
	(SELECT MIN(Salary) From Employees)