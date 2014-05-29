using System;


class Calculate
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        if (k > 1 && n > k && 100 > n)
        {
            int result1 = 1;
            int result2 = 1;
            int result;
            int count = 1;

            for (int index = n - k + 1; index <= n; index++)
            {
                result1 *= index;
                if (count <= k)
                {
                    result2 *= count;
                    count++;
                }
            }
            result = result1 / result2;
            Console.WriteLine("N!/K! = {0}", result);
        }
        else
        {
            Console.WriteLine("You didn't enter integers in interval [1 < k < n < 100]");
        }
    }
}
