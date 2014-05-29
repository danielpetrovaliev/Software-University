using System;
using System.Text;


class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());        
        if (a <= 500 & a >= 0)
        {
            Console.Write("Enter b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("| {0,-10:X} | {1} | {2,10:F2} | {3,-10:F3} |", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
        else
        {
            Console.WriteLine("Number a is not between 0 <= a <= 500.");
        }
    }
}
