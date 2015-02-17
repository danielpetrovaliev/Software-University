SELECT t.Name as Town, d.Name as [Department Name], COUNT(e.EmployeeID) as [Employees Count]
FROM Departments d
	JOIN Employees e
		ON d.DepartmentID = e.DepartmentID
	JOIN Addresses a
		ON a.AddressID = e.AddressID
	JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY d.Name, t.Name
ORDER BY d.Name