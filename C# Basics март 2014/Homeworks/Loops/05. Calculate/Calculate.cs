using System;


class Calculate
{
    static void Main()
    {
        Console.Write("Please, enter a whole positive number for N = ");
        string inputStr = Console.ReadLine();
        int numN = int.Parse(inputStr);
        Console.Write("Enter a whole integer number for X = ");
        inputStr = Console.ReadLine();
        int numX = int.Parse(inputStr);
        if (numN < 1)
        {
            Console.WriteLine("Error - Invalid Number !!!");
        }
        else
        {
            // The formula is Sum = 1 + 1!/X + 2!/X^2 + … + N!/X^N

            double factorialN = 1;
            double numXPowerN = 1;
            double sumOfSequence = 1;
            for (int i = 1; i <= numN; i++)
            {
                factorialN *= i;
                numXPowerN *= numX;
                sumOfSequence += (factorialN / numXPowerN);
            }
            Console.WriteLine("The Sum of sequence of these numbers N and X is SUM = {0:F5} !",
                sumOfSequence);
        }
        Console.ReadLine();
    }
}
