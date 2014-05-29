using System;


class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        float c = float.Parse(Console.ReadLine());
        Console.Write("Enter d: ");
        float d = float.Parse(Console.ReadLine());
        Console.Write("Enter e: ");
        float e = float.Parse(Console.ReadLine());

        if ((a>b)&&(a>c)&&(a>d)&&(a>e))
        {
            Console.WriteLine("The biggest number is \" {0} \" ",a);
        }
        else if ((b>a)&&(b>c)&&(b>d)&&(b>e))
        {
            Console.WriteLine("The biggest number is \" {0} \" ", b);
        }
        else if ((c>a)&&(c>b)&&(c>d)&&(c>e))
        {
            Console.WriteLine("The biggest number is \" {0} \" ", c);
        }
        else if ((d>a)&&(d>b)&&(d>c)&&(d>e))
        {
            Console.WriteLine("The biggest number is \" {0} \" ", d);
        }
        else
        {
            Console.WriteLine("The biggest number is \" {0} \" ", e);
        }
    }
}
