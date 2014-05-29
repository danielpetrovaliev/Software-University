using System;


class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Original: a = {0}, b = {1}", a,b);
        a ^= b;
        b ^= a;
        a ^= b;
        Console.WriteLine("Exchanged: a = {0}, b = {1}", a, b);
    }
}
