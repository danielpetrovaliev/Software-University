using System;


class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Quadratic Equation :  ");
        Console.WriteLine("ax^2 + bx + c =0");
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        
        double disc = b * b - 4 * a * c;
        
        if (disc < 0)
        {
            Console.WriteLine("No real roots");
        }
        if (disc > 0)
        {
            Console.WriteLine("X1 = {0}\nX2 = {1}", (-b + Math.Sqrt(disc)) / 2 * a, (-b - Math.Sqrt(disc)) / 2 * a);
        }
        if (disc == 0)
        {
            Console.WriteLine("X1=X2 = {0}", (-b + Math.Sqrt(disc)) / 2 * a);
        }
        

    }
}
