using System;


class NumberNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n ; i++)
        {

            if ((i % 3 == 0) || (i % 7 == 0))
            {
                continue;
            }
            Console.Write(i + " ");
        }
    }
}
