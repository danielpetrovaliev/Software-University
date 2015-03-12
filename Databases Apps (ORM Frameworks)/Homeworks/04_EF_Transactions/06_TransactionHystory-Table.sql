USE ATM
GO

CREATE TABLE TransactionHistory(
	Id int IDENTITY PRIMARY KEY,
	CardNumber nvarchar(10) NOT NULL,
	TransactionDate datetime2 NOT NULL,
	Amount money NOT NULL
)