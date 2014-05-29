using System;


class Fir
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dots = n - 2;
        int asteriks = 1;

        while (dots >= 0)
        {
            Console.Write(new string('.',dots));
            Console.Write(new string('*', asteriks));
            Console.WriteLine(new string('.', dots));

            dots--;
            asteriks += 2;
        }

        Console.Write(new string('.', n - 2));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('.', n - 2));

    }
}