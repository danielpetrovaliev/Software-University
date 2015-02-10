SELECT e.FirstName, 
	e.LastName, 
	employeeAdress.AddressText, 
	e.ManagerID, 
	m.FirstName,
	m.LastName,
	managerAdress.AddressText,
	m.EmployeeID
FROM Employees e
INNER JOIN Employees m
	ON e.ManagerID = m.EmployeeID
INNER JOIN Addresses employeeAdress
	ON e.AddressID = employeeAdress.AddressID
INNER JOIN Addresses managerAdress
	ON m.AddressID = managerAdress.AddressID
