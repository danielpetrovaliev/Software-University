using System;


class BinToDec
{
    static void Main()
    {
        Console.Write("Binary: ");
        string str = Console.ReadLine();
        int[] numbers = new int[str.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (str[i] == '1')
                numbers[i] = 1;
            else
                numbers[i] = 0;
        }


        long dec = 0;

        int power = 0;
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] % 2 == 1)
                dec += ((long)(Math.Pow(2, power)));
            power++;
        }

        Console.WriteLine("Decimal: " + dec);
    }
}