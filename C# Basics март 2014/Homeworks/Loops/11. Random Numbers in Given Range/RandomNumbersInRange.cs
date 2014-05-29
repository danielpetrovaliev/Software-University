using System;


class RandomNumbersInRange
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter Min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter Max: ");
        int max = int.Parse(Console.ReadLine());

        if (min <= max)
        {
            Console.Write("Random numbers: ");
            Random rng = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write(rng.Next(min, max + 1) + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("You entered inappropriate values.");
        }
    }
}
