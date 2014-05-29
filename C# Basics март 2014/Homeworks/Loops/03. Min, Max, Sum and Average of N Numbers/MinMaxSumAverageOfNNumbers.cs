using System;


class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int max = int.MinValue;
        int min = int.MaxValue;
        double sum = 0;
        double avg = 0;
        double sumavg = n;


        while (n > 0)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
            sum += num;

            avg = sum / sumavg;
            n--;
        }

        Console.WriteLine("Min = {0}",min);
        Console.WriteLine("Max = {0}",max);
        Console.WriteLine("Sum = {0}",sum);
        Console.WriteLine("Average = {0:F2}",avg);
    }
}

