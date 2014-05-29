using System;


class Cinema
{
    static void Main()
    {
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int colls = int.Parse(Console.ReadLine());
        int peoples = rows * colls;
        decimal premiiere = 12;
        decimal normal = 7.5m;
        decimal discount = 5;
        decimal price = 1;

        if (type == "Premiere")
        {
            price = peoples * premiiere;
        }

        else if (type == "Normal")
	    {
		    price = peoples * normal;
	    }

        else
        {
            price = peoples * discount;
        }

        Console.WriteLine("{0:F2} leva",price);
    }
}
