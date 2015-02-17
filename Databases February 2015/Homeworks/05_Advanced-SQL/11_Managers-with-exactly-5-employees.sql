SELECT m.FirstName, m.LastName, COUNT(e.EmployeeID)
FROM Employees m
	JOIN Employees e
		ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(m.EmployeeID) = 5