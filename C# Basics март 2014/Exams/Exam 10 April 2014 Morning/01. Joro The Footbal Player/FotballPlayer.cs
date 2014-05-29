using System;


class FotballPlayer
{
    static void Main()
    {

        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        float games = 0;
        int weekends = 52;

        if (year == "t")
        {
            games += (p * 1 / 2);
            games += h;
            games += (weekends - h) * 2 / 3;
            games += 3;
        }
        else if (year == "f")
        {
            games += (p * 1 / 2);
            games += (weekends - h) * 2 / 3;
            games += h;
        }

        Console.WriteLine(games);

    }
}
