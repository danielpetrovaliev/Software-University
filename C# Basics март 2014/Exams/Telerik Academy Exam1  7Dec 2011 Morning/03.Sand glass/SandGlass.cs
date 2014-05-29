using System;


class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outsideCounter = 0;
        int insideCounter = n;
        for (int i = 0; i < (n+1)/2; i++)
        {
            Console.Write(new string('.',outsideCounter));
            Console.Write(new string('*', insideCounter));
            Console.WriteLine(new string('.', outsideCounter));

            outsideCounter++;
            insideCounter -= 2;
        }

        int DownOutsideCounter = n / 2 - 1;
        int DownInsideCounter = 3;
        for (int i = 0; i < n - ((n+1)/2); i++)
        {
            Console.Write(new string('.', DownOutsideCounter));
            Console.Write(new string('*', DownInsideCounter));
            Console.WriteLine(new string('.', DownOutsideCounter));
            DownOutsideCounter--;
            DownInsideCounter += 2;
        }
    }
}