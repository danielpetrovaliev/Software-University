using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        
        
        for (int y = 1; y <= n; y++)
        {
            for (int x = 1; x <= n; x++)
            {
                if ((x - ((n + 1) / 2)) * (x - ((n + 1) / 2)) + (y - ((n + 1) / 2)) * (y - ((n + 1) / 2)) <= r * r)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
                
            }
            Console.WriteLine();
        }

    }
}