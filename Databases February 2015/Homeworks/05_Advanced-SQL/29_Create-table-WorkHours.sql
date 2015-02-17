USE SoftUni
GO

CREATE TABLE WorkHours (
  ID int IDENTITY(1, 1),
  EmployeeID int NOT NULL,
  DateOfReport datetime NOT NULL DEFAULT(GETDATE()),
  Task text NOT NULL,
  [Hours] time NOT NULL,
  CONSTRAINT PK_WorkHours PRIMARY KEY(ID),
  CONSTRAINT FK_WorkHours_Employees FOREIGN KEY(EmployeeID)
    REFERENCES Employees(EmployeeID)
)
GO