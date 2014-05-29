using System;



class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dot = n - 2;
        int slash = 1;
        int backslash = 1;
        int insideCounter = 0;
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string('.',dot));
            Console.Write(new string('/', slash));
            Console.Write(new string(' ', insideCounter));
            Console.Write(new string('\\', backslash));
            Console.WriteLine(new string('.', dot));
            dot--;
            insideCounter += 2;
            
        }
    }
}