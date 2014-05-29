using System;



class ExtractBitFromIneger
{
    static void Main()
    {
        Console.Write("Enter number : ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter position : ");
        int p = int.Parse(Console.ReadLine());

        int bit = (number >> p) & 1;
        Console.WriteLine("Bit : {0}",bit);
    }
}
