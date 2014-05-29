using System;


class PrintDeckOf52Cards
{
    static void Main()
    {
        string card = "2";
        for (int i = 2; i < 14; i++)
			{
                if (i <= 10)
                {
                    Console.Write(i);
                    card = Convert.ToString(i);
                }
                else if (i == 11)
                {
                    card = "J";
                    Console.Write(card);

                }
                else if (i == 12)
                {
                    card = "Q";
                    Console.Write(card);
                }
                else if (i == 13)
                {
                    card = "K";
                    Console.Write(card);
                }
                else if (i == 14)
                {
                    card = "A";
                    Console.Write(card);
                }
                for (int face = 1; face <= 4; face++)
                {
                    switch (face)
                    {
                        case 1:
                            Console.Write("♣");
                            Console.Write(card);
                            break;
                        case 2:
                            Console.Write("♦");
                            Console.Write(card);
                            break;
                        case 3:
                            Console.Write("♥");
                            Console.Write(card);
                            break;
                        case 4:
                            Console.WriteLine("♠");
                            break;
                    }
                }
			}
        
    }
}
