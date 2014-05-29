using System;


class SumOfN
{
    static void Main()
    {
        Console.Write("Enter how much numbers you want to sum:");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number " + (i + 1) + " :");
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Their sum is:" + sum);
        Console.WriteLine();
    }
}
