SELECT e.FirstName + ' ' + e.LastName AS FullName, 
	e.ManagerID, 
	m.FirstName + ' ' + m.LastName AS FullName, 
	m.EmployeeID
FROM Employees e
LEFT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID