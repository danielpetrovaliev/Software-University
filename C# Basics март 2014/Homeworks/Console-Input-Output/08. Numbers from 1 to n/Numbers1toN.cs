using System;


class Numbers1toN
{
    static void Main()
    {
        Console.Write("Numbers: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}

