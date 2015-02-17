SELECT d.Name as [Department Name], 
	e.JobTitle, 
	MIN(e.FirstName) as [Employee FirstName], 
	AVG(e.Salary) as [Min Salary]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, JobTitle
ORDER BY [Department Name]