using System;


class OddOrEven
{
    static void Main()
    {
        Console.WriteLine(!(int.Parse(Console.ReadLine()) % 2 == 0));
    }
}
