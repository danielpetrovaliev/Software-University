SELECT e.FirstName + ' ' + e.LastName as Employee, 
	IsNull(m.FirstName + ' ' + m.LastName, '(no manager)')  as Manager
FROM Employees e
	LEFT JOIN Employees m
		ON e.ManagerID = m.EmployeeID