using System;
class DecToHex
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long n = long.Parse(Console.ReadLine());


        string result = "";


        for (; n != 0; n /= 16)
        {
            if (n % 16 == 15)
                result += "F";
            else if (n % 16 == 14)
                result += "E";
            else if (n % 16 == 13)
                result += "D";
            else if (n % 16 == 12)
                result += "C";
            else if (n % 16 == 11)
                result += "B";
            else if (n % 16 == 10)
                result += "A";
            else
                result += (char)(48 + n % 16);

        }

        char[] forReverse = result.ToCharArray();
        Array.Reverse(forReverse);
        result = new string(forReverse);

        Console.WriteLine("The number in hexadecimal: " + result);


    }
}