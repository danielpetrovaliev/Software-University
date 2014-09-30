using System;

public delegate decimal CalculateInterest(decimal sum, double interest, int years);
public class InterestCalculator
{
    private decimal sum;
    private double interest;
    private CalculateInterest type;
    private int years;


    public InterestCalculator(decimal sum, double interest, int years, CalculateInterest type)
    {
        this.sum = sum;
        this.interest = interest;
        this.years = years;
        this.type = type;
    }


    public override string ToString()
    {
        return String.Format("{0:F4}", this.type(this.sum, this.interest, this.years));
    }
    

}
