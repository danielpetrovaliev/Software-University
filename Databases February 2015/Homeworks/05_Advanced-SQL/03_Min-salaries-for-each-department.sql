SELECT FirstName + ' ' + LastName as FullName, Salary, d.Name as DepName
FROM Employees e
INNER JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE Salary =
	(SELECT MIN(Salary) 
	From Employees
	WHERE e.DepartmentID = DepartmentID)