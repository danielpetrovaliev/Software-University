using System;


class ChechThirdDigit
{
    static void Main()
    {
        Console.Write("Insert a Number : ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine((num / 100)%10 == 7 ? true : false);
    }
}
