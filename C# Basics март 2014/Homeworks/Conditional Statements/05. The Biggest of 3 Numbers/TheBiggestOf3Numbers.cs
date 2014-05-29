using System;


class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        float c = float.Parse(Console.ReadLine());

        if ((a<b) && (b>c))
        {
            Console.WriteLine("The biggest number is \" {0} \" ",b);
        }
        else if ((b<a) && (a>c))
        {
            Console.WriteLine("The biggest number is \" {0} \" ", a);
        }
        else
        {
            Console.WriteLine("The biggest number is \" {0} \" ", c);
        }
    }
}
