using System;

class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string(' ',1));
        Console.Write(new string('*', 2 * n - 2));
        Console.Write(new string(' ', 1));
        Console.Write(new string(' ', n - 1));
        Console.Write(new string(' ', 1));
        Console.Write(new string('*', 2 * n - 2));
        Console.WriteLine(new string(' ', 1));

        for (int i = 1; i <= n - 2; i++)
        {
            if (i == n / 2)
            {
                Console.Write(new string('*',1));
                Console.Write(new string('/', 2 * n - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', n - 1));
                Console.Write(new string('*', 1));
                Console.Write(new string('/', 2 * n - 2));
                Console.WriteLine(new string('*', 1));
            }
            else
            {
                Console.Write(new string('*', 1));
                Console.Write(new string('/', 2 * n - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', n - 1));
                Console.Write(new string('*', 1));
                Console.Write(new string('/', 2 * n - 2));
                Console.WriteLine(new string('*', 1));
            }
        }

        Console.Write(new string(' ', 1));
        Console.Write(new string('*', 2 * n - 2));
        Console.Write(new string(' ', 1));
        Console.Write(new string(' ', n - 1));
        Console.Write(new string(' ', 1));
        Console.Write(new string('*', 2 * n - 2));
        Console.WriteLine(new string(' ', 1));
    }
}