using System;


class OddAndEvenProduct
{
    static void Main()
    {
        int even = 1;
        int odd = 1;

        Console.Write("Enter a numbers, given in a single line and separated by a space: ");
        string readNumbers = Console.ReadLine();
        string[] numbers = readNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);

            if (i % 2 == 0)
            {
                even *= number;
            }
            else
            {
                odd *= number;
            }
        }

        if (even == odd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = " + even);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + odd);
            Console.WriteLine("even_product = " + even);
        }
    }
}
