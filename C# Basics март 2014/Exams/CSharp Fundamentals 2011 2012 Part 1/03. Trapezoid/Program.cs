using System;



class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        Console.Write(new string('.',n));
        Console.WriteLine(new string('*',n));
        int insideCounter = n - 1;
        int outsideCounter = n - 1;

        while (outsideCounter >= 1)
        {
            Console.Write(new string('.',outsideCounter));
            Console.Write(new string('*',1));
            Console.Write(new string('.',insideCounter));
            Console.WriteLine(new string('*', 1));

            insideCounter++;
            outsideCounter--;
        }
        Console.WriteLine(new string('*',2*n));
    }
}