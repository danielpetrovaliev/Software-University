using System;


class Bitwise
{
    static void Main()
    {
        Console.Write("Enter number : ");
        int number = int.Parse(Console.ReadLine());
        int p = 3;
        int bit = (number >> p) & 1;
        Console.WriteLine(bit);
    }
}
