using System;


class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Enter a:");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter c:");
        float c = float.Parse(Console.ReadLine());

        if ((a>b)&&(a>c))
        {
            if (b>c)
            {
                Console.WriteLine("Result: {0} {1} {2}",a,b,c);
            }
            else
            {
                Console.WriteLine("Result: {0} {1} {2}", a, c, b);
            }
        }
        if ((b>a)&(b>c))
        {
            if (a>c)
            {
                Console.WriteLine("Result: {0} {1} {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("Result: {0} {1} {2}", b, c, a);
            }
        }
        if ((c>a)&&(c>b))
        {
            if (a>b)
            {
                Console.WriteLine("Result: {0} {1} {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("Result: {0} {1} {2}", c, b, a);
            }
        }
        if ((a == b) && (b == c))
        {
            if (c == a)
            {
                Console.WriteLine("Result: {0} {1} {2}", c, b, a);
            }
        }
    }
}
