using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("What is your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Aften 10 years you'll be {0} years old", age+10);
    }
}