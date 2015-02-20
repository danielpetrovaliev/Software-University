USE SoftUni
GO

CREATE PROC usp_SelectPersonsByBalance(
	@moneyBalance int)
AS
	SELECT p.Id, 
		p.FirstName, 
		p.LastName,
		p.SSN,
		a.balance 
	FROM Persons p
		JOIN Accounts a	
			ON p.Id = a.PersonId
	Where a.Balance >= @moneyBalance
GO

EXEC usp_SelectPersonsByBalance 10