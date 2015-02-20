USE SoftUni
GO

CREATE TABLE Persons(
	Id int NOT NULL IDENTITY,
	FirstName nvarchar(100) NOT NULL,
	LastName nvarchar(100) NOT NULL,
	SSN nvarchar(20) NOT NULL,
	CONSTRAINT PK_Persons PRIMARY KEY(Id)
	)
GO

CREATE TABLE Accounts(
	Id int NOT NULL IDENTITY,
	PersonId int NOT NULL,
	balance money NOT NULL,
	CONSTRAINT PK_Accounts PRIMARY KEY(Id),
	CONSTRAINT FK_Accounts_Persons FOREIGN KEY(PersonId)
		REFERENCES Persons(Id)
	)
GO

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES('Pesho', 'Peshev', '4002027489'),
('Gosho', 'Goshev', '7802027598')
GO

INSERT INTO Accounts(PersonId, balance)
VALUES(1, 10.00), (2, 300.00)
GO

--Stored procedure
CREATE PROC usp_SelectFullNameOfPersons
AS
  SELECT FirstName + ' ' + LastName as FullName 
   FROM Persons
GO


EXEC usp_SelectFullNameOfPersons
GO