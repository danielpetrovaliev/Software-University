ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees
GO
ALTER TABLE Departments
ADD CONSTRAINT FK_Departments_Employees FOREIGN KEY (ManagerID)
REFERENCES Employees(EmployeeID)
ON DELETE CASCADE
ON UPDATE NO ACTION
GO

BEGIN TRAN
DELETE
	FROM Employees
	WHERE DepartmentID = 3;
ROLLBACK TRAN

