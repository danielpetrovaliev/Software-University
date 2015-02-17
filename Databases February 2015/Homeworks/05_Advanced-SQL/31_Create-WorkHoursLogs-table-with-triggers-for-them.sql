CREATE TABLE WorkHoursLogs(
	ID int NOT NULL PRIMARY KEY IDENTITY,
	WorkHoursID int NOT NULL, 	
	OldRecord nvarchar(max),
	NewRecord nvarchar(max),
	CommandType nvarchar(20)
)
GO

CREATE TRIGGER tr_AccountsUpdate ON WorkHours FOR UPDATE
AS
	INSERT INTO WorkHoursLogs(WorkHoursID, OldRecord, NewRecord, CommandType)
	SELECT i.ID, d.Task, i.Task, 'UPDATE'
	FROM DELETED d, INSERTED i
GO

CREATE TRIGGER tr_AccountsDelete ON WorkHours FOR DELETE
AS
	INSERT INTO WorkHoursLogs(WorkHoursID, OldRecord, NewRecord, CommandType)
	SELECT d.ID, d.Task, NULL, 'DELETE'
	FROM DELETED d
GO

CREATE TRIGGER tr_AccountsInsert ON WorkHours FOR INSERT
AS
	INSERT INTO WorkHoursLogs(WorkHoursID, OldRecord, NewRecord, CommandType)
	SELECT i.ID, NULL, i.Task, 'INSERT'
	FROM INSERTED i
GO