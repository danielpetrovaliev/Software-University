USE SoftUni
GO

CREATE VIEW view_UsersToday AS
SELECT * 
FROM Users
WHERE DAY(LastLogin) = DAY(GETDATE())

