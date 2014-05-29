using System;


class Sunglases
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('*',2*n));
        Console.Write(new string(' ',n));
        Console.Write(new string('*', 2 * n));
        Console.WriteLine();

        for (int i = 1; i <= n - 2; i++)
        {
            if (i == n / 2)
            {
                Console.Write(new string('*',1));
                Console.Write(new string('/', 2 * n - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('|', n));
                Console.Write(new string('*', 1));
                Console.Write(new string('/', 2 * n - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine();
            }

            else
            {
                Console.Write(new string('*', 1));
                Console.Write(new string('/', 2 * n - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', n));
                Console.Write(new string('*', 1));
                Console.Write(new string('/', 2 * n - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine();
            }
        }

        Console.Write(new string('*', 2 * n));
        Console.Write(new string(' ', n));
        Console.Write(new string('*', 2 * n));
        Console.WriteLine();
    }
}
