SELECT e.FirstName, e.LastName
FROM Employees e, Departments d
WHERE e.HireDate BETWEEN '1995' AND '2005' AND
	(e.DepartmentID = d.DepartmentID) AND
	(d.Name = 'Finance' OR d.Name = 'Sales')