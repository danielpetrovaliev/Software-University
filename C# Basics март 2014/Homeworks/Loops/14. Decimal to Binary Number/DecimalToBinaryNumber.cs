using System;


class DecToBin
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long n = long.Parse(Console.ReadLine());

        string result = "";


        for (; n != 0; n /= 2)
        {
            if (n % 2 == 1)
                result += "1";
            else
                result += "0";
        }

        char[] forReverse = result.ToCharArray();
        Array.Reverse(forReverse);
        result = new string(forReverse);



        Console.WriteLine("Binary: " + result);

    }
}