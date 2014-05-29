using System;


class CheckBitGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number : ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter position : ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter value : ");
        int v = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        if (v == 0)
        {
            mask = ~mask;
            number = number & mask;
            Console.WriteLine("Result : {0}",number);
        }
        else if (v == 1)
        {
            number = number | mask;
            Console.WriteLine("Result : {0}",number);
        }
    }
}
