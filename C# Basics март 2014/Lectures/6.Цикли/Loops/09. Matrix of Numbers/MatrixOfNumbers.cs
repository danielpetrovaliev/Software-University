using System;


class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter a positive integer in interval [1 <= n <= 20]: ");
        int n = int.Parse(Console.ReadLine());

        if ((1 <= n) && (n <= 20))
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n + i; j++)
                {
                    Console.Write("{0,-2} ", j);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("You don't enter a positive integer in interval [1 <= n <= 20]");
        }
        Console.WriteLine();
    }
}
