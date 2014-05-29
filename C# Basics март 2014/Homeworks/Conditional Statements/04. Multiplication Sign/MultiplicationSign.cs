using System;


class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine();

        if (a*b*c > 0)
        {
            Console.WriteLine("Result is \"+\" ");
        }
        else if (a*b*c == 0)
        {
            Console.WriteLine("Result is \"0\" ");
        }
        else
        {
            Console.WriteLine("Result is \"-\" ");
        }
    }
}
