using System;

class NestedIf
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers (on separate lines).");

        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        if (first == second)
        {
            Console.WriteLine("These two numbers are equal.");
        }
        else
        {
            Console.WriteLine("Different numbers.");
            if (first > second)
            {
                Console.WriteLine("The first number is greater.");
            }
            else
            {
                Console.WriteLine("The second number is greater.");
            }
        }
    }
}
