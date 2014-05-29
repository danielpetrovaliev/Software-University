using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter four-digit number:");
        int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine(!(number > 9999 || number < 1000));
        
        int numA = number / 1000;
        int numB = (number / 100) % 10;
        int numC = (number / 10) % 10;
        int numD = number % 10;
        int sum = numA + numB + numC + numD;

        Console.WriteLine("Sum of digits: " + sum);
        Console.WriteLine("In reversed order: {0} {1} {2} {3}", numD, numC, numB, numA);
        Console.WriteLine("Last digit in the first position: {0} {1} {2} {3}", numD, numA, numB, numC);
        Console.WriteLine("Exchanged second and the third digits: {0} {1} {2} {3}", numA, numC, numB, numD);

    }
}
