using System;


class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            if (i == 10)
            {
                Console.WriteLine();
            }
        }
    }
}
