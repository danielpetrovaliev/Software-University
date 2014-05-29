using System;


class CalculateNK
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        if (k > 1 && n > k && 100 > n)
        {
            ulong resuult = 1;
            for (int index = k + 1; index <= n; index++)
            {
                resuult *= (ulong)index;
            }
            Console.WriteLine("N!/K! = {0}",resuult);
        }
        else
        {
            Console.WriteLine("You didn't enter integers in interval [1 < k < n < 100]");
        }
    }
}
