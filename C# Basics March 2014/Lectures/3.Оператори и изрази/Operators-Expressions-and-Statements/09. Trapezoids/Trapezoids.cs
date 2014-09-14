using System;


class Trapezoids
{
    static void Main()
    {
        Console.Write("Insert a : ");
        double baseA = double.Parse(Console.ReadLine());
        Console.Write("Insert b : ");
        double baseB = double.Parse(Console.ReadLine());
        Console.Write("Insert h : ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Area is : {0}", ((baseA + baseB) / 2) * height);

    }
}
