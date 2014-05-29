using System;



class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] elements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            oddSum =+ elements[i];
        }
    }
}