USE SoftUni
GO

CREATE PROC usp_GiveInterestoToPersonAccount (@accountId int, @interestRate float)
AS
	UPDATE Accounts
	SET Balance = dbo.ufn_CalcInterest(Balance, @interestRate, 1)
	WHERE Id = @accountId
GO

SELECT * FROM Accounts

EXEC usp_GiveInterestoToPersonAccount 1, 2.50
