SELECT e.FirstName, e.LastName, e.ManagerID, m.EmployeeID, m.FirstName, m.LastName
FROM Employees e
INNER JOIN Employees m
	ON	e.ManagerID = m.EmployeeID