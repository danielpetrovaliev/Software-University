USE SoftUni
GO 

INSERT INTO WorkHours(EmployeeID, Task, Hours)
VALUES(1, 'first task', '02:00:00')

INSERT INTO WorkHours(EmployeeID, Task, Hours)
VALUES(3, 'Second task', '00:20:00')

INSERT INTO WorkHours(EmployeeID, Task, Hours)
VALUES(25, 'Third task', '02:00:00')

UPDATE WorkHours
SET Task = 'updated'
WHERE ID = 1

DELETE WorkHours
WHERE ID=1
