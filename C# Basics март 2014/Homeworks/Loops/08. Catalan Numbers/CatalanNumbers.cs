using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        if (n > 1 && n < 100)
        {
            BigInteger multiFactN = 1;
            BigInteger plusFactN = 1;
            BigInteger factN = 1;
            BigInteger result = 0;

            for (int i = 1; i <= 2 * n; i++)
            {
                multiFactN *= i;
            }

            for (int j = 1; j <= n + 1; j++)
            {
                plusFactN *= j;
            }

            for (int k = 1; k <= n; k++)
            {
                factN *= k;
            }

            result = multiFactN / (plusFactN * factN);

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}