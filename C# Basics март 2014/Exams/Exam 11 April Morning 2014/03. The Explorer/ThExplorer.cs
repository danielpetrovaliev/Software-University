using System;



class ThExplorer
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('-', n / 2));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('-', n / 2));

        int outsideCounter = n / 2 - 1;
        int insideCounter = 1;

        while (outsideCounter != 0)
        {
            Console.Write(new string('-', outsideCounter));
            Console.Write(new string('*', 1));
            Console.Write(new string('-', insideCounter));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('-', outsideCounter));

            outsideCounter--;
            insideCounter += 2;
        }
        Console.Write(new string('*',1));
        Console.Write(new string('-', n - 2));
        Console.Write(new string('*', 1));
        Console.WriteLine();

        int downOutsideCounter = 1;
        int downInsideCounter = n - 4;

        while (downOutsideCounter <= n / 2 - 1)
        {
            Console.Write(new string('-', downOutsideCounter));
            Console.Write(new string('*', 1));
            Console.Write(new string('-', downInsideCounter));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('-', downOutsideCounter));


            downInsideCounter -= 2;
            downOutsideCounter++;
        }
        Console.Write(new string('-', n / 2));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('-', n / 2));
    }
}