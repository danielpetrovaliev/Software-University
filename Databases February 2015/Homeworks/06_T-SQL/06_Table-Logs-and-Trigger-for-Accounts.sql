USE SoftUni
GO

CREATE TABLE Logs(
	LogID int NOT NULL IDENTITY,
	AccountID int NOT NULL,
	OldSum money NOT NULL,
	NewSum money NOT NULL,
	CONSTRAINT PK_Logs PRIMARY KEY(LogID),
	CONSTRAINT FK_Logs_Accounts FOREIGN KEY(AccountID)
		REFERENCES Accounts(Id)
)
GO

CREATE TRIGGER tr_AccountBalanceUpdate ON Accounts FOR UPDATE
AS
	INSERT INTO Logs(AccountID, OldSum, NewSum)
	SELECT i.Id, d.balance, i.balance
	FROM DELETED d, INSERTED i
GO