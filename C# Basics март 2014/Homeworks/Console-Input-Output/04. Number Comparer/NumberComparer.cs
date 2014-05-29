using System;



class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Greater is: ");
        Console.WriteLine(Math.Max(a, b));
        
    }
}
