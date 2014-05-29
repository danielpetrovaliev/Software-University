using System;


class Encrypt248
{
    static void Main()
    {
        long a = int.Parse(Console.ReadLine());
        long b = int.Parse(Console.ReadLine());
        long c = int.Parse(Console.ReadLine());
        long r = 0;

        if (b == 2)
        {
            r = a % c;
        }

        else if (b == 4)
        {
            r = a + c;
        }

        else if (b == 8)
        {
            r = a * c;
        }

        if (r % 4 == 0)
        {
            long result = r / 4;
            Console.WriteLine(result);
        }
        else
        {
            long result = r % 4;
            Console.WriteLine(result);
        }
        Console.WriteLine(r);
    }
}