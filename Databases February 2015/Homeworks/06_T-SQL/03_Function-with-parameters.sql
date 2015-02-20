CREATE FUNCTION ufn_CalcInterest (@sum money, @interestRate float, @months int)
  RETURNS money
AS
BEGIN
	RETURN @sum + (@sum * ( (@interestRate / 100)  * @months))
END
GO

SELECT dbo.ufn_CalcInterest (10000, 2.00, 12)