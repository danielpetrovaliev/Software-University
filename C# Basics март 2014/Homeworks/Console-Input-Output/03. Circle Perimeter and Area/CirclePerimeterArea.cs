using System;


class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double r = double.Parse(Console.ReadLine());
        double p = 3.14159265359;
        Console.WriteLine();
        Console.WriteLine("Perimeter is: {0:F2}\nArea is: {1:F2}", 2*p*r,p*r*r);
    }
}

