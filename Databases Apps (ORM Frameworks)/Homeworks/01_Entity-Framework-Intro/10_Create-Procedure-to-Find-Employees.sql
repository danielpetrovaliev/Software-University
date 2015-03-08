USE SoftUni
GO

CREATE PROCEDURE usp_FindTotalProjectsForEmployee (@firstName NVARCHAR(MAX), @lastName NVARCHAR(MAX))
AS
	SELECT COUNT(p.ProjectID)
	FROM dbo.Employees e
		FULL JOIN dbo.EmployeesProjects ep
			ON ep.EmployeeID = e.EmployeeID
		FULL JOIN dbo.Projects p
			ON p.ProjectID = ep.ProjectID
	WHERE e.FirstName = @firstName AND 
		e.LastName = @lastName
	GROUP BY e.EmployeeID
GO