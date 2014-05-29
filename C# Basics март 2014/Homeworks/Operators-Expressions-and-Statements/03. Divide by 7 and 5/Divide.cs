using System;


class Divide
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        
        Console.WriteLine(num == 0 ? false : num % 7 == 0 && num % 5 ==0);
    }
}
