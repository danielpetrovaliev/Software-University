using System;


class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Insert a : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Insert b : ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Insert c : ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of {0}, {1}, {2} is {3}",a,b,c,a+b+c);
    }
}

