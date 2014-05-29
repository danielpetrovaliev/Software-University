using System;



class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('-', n / 2));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('-', n / 2));

        int outsideCounter = n / 2 - 1;
        int insideCounter = 3;
        while (outsideCounter != 0)
        {
            Console.Write(new string('-', outsideCounter));
            Console.Write(new string('*', insideCounter));
            Console.WriteLine(new string('-', outsideCounter));

            outsideCounter--;
            insideCounter += 2;
        }
        Console.WriteLine(new string('*', n));
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('|',1));
            Console.Write(new string('*', n - 2));
            Console.Write(new string('|', 1));
            Console.WriteLine();
        }
    }
}