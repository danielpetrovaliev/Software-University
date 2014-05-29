using System;


class NumberChech
{
    static void Main()
    {
        Console.Write("Insert a number : ");
        int number = int.Parse(Console.ReadLine());
        int divByTwo = number / 2;
        int divByThree = number / 3;
        int divByFive = number / 5;
        if (number > 0)
        {
            Console.WriteLine((number != 2 && number == divByTwo * 2) || (number != 3 && number == divByThree * 3) || (number != 5 && number == divByFive * 5) ? number + " is NOT prime numeber!" : number + " is prime number!");
        }
        else Console.WriteLine(number + " is Not Prime!");
        Main();

    }
}
