using System;


class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        float b = float.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("{1} {0}",a,b);
        }
        else
        {
            Console.WriteLine("{0} {1}",a,b);
        }

    }
}
