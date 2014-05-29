using System;



class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int upperOutsideCounter = n / 2;
        int upperInsideCounter = n - 2;

        Console.Write(new string('.',upperOutsideCounter));
        Console.Write(new string('#', n));
        Console.WriteLine(new string('.', upperOutsideCounter));

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.',upperOutsideCounter));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', upperInsideCounter));
            Console.Write(new string('#', 1));
            Console.WriteLine(new string('.', upperOutsideCounter));
        }
        Console.Write(new string('#', upperOutsideCounter + 1));
        Console.Write(new string('.', upperInsideCounter));
        Console.WriteLine(new string('#', upperOutsideCounter + 1));

        int bottomOutsideCounter = 1;
        int bottomInsideCounter = 2 * n - 5;

        while (bottomInsideCounter > 0)
        {
            Console.Write(new string('.',bottomOutsideCounter));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', bottomInsideCounter));
            Console.Write(new string('#', 1));
            Console.WriteLine(new string('.', bottomOutsideCounter));
            bottomOutsideCounter++;
            bottomInsideCounter -= 2;
        }
        Console.Write(new string('.', n-1));
        Console.Write(new string('#', 1));
        Console.WriteLine(new string('.', n-1));
    }
}