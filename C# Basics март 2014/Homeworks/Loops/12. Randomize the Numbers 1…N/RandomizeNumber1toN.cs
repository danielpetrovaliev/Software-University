using System;


class RandomizeNumber1toN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Random numbers: ");
        Random randomNumbers = new Random();

        for (int i = 1; i <= n; i++)
        {
            Console.Write(randomNumbers.Next(1,n + 1) + " ");
        }

        Console.WriteLine();
    }
}
