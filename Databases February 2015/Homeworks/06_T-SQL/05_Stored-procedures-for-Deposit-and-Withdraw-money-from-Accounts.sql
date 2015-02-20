USE SoftUni
GO

CREATE PROC usp_WithdrawMoney (@accountId int, @money money)
AS
	UPDATE Accounts
	SET Balance = (Balance - @money)
	WHERE Id = @accountId
GO

CREATE PROC usp_DepositMoney (@accountId int, @money money)
AS
	UPDATE Accounts
	SET Balance = (Balance + @money)
	WHERE Id = @accountId
GO

SELECT * FROM Accounts

EXEC usp_DepositMoney 1, 5.50

EXEC usp_WithdrawMoney 1, 5.50