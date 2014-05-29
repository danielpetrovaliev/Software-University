using System;


class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('\\',0));

        int insideCounter = n - 2;
        int outsideCounter = 0;

        while (insideCounter >= 0)
        {
            Console.Write(new string('.', outsideCounter));
            Console.Write(new string('\\', 1));
            Console.Write(new string('*', insideCounter));
            Console.Write(new string('/',1));
            Console.WriteLine(new string('.', outsideCounter));
            outsideCounter++;
            insideCounter -= 2;
        }

        if (n >= 12)
        {
            for (int i = 0; i < (n / 2) - 2; i++)
            {
                Console.Write(new string('.', n / 2 - 1));
                Console.Write(new string('|',2));
                Console.WriteLine(new string('.', n / 2 - 1));
            }
            Console.WriteLine(new string('-', n));
            Console.WriteLine(new string('-', n));
        }
        else
        {
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.Write(new string('.', n / 2 - 1));
                Console.Write(new string('|', 2));
                Console.WriteLine(new string('.', n / 2 - 1));
            }
            Console.WriteLine(new string('-', n));
        }
    }
}