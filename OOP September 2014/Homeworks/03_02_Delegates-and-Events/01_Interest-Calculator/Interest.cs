using System;

class Program
{
    static void Main()
    {
        var firstSum = new InterestCalculator(500m, 5.6, 10, GetCompoundInterest);
        var secondSum = new InterestCalculator(2500m, 7.2, 15, GetSimpleInterest);

        Console.WriteLine(firstSum);
        Console.WriteLine(secondSum);

    }

    private static decimal GetSimpleInterest(decimal moneySum, double interest, int years)
    {
        // A = sum * (1 + interest * years)
        decimal simpleInterest = moneySum * (decimal)(1 + (interest * years / 100));
        return simpleInterest;
    }
    private static decimal GetCompoundInterest(decimal moneySum, double interest, int years)
    {
        decimal compoundInterest = moneySum * (decimal)Math.Pow(1 + (interest / 12 / 100), years * 12);
        return compoundInterest;
    }
    
}

