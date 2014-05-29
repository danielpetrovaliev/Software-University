using System;


class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your age:");
        int Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age after 10 years will be:{0}", Age + 10);
    }
}
