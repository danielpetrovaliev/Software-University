using System;


class HexToDec
{
    static void Main()
    {


        Console.Write("Input hexadecimal number: ");
        string str = Console.ReadLine();



        long dec = 0;

        int power = 0;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            int decNumber;

            if (str[i] == 'F')
                decNumber = 15;
            else if (str[i] == 'E')
                decNumber = 14;
            else if (str[i] == 'D')
                decNumber = 13;
            else if (str[i] == 'C')
                decNumber = 12;
            else if (str[i] == 'B')
                decNumber = 11;
            else if (str[i] == 'A')
                decNumber = 10;
            else
                decNumber = str[i] - 48;

            dec += (((long)Math.Pow(16, power)) * decNumber);
            power++;
        }

        Console.WriteLine("Number in decimal: " + dec);


    }
}