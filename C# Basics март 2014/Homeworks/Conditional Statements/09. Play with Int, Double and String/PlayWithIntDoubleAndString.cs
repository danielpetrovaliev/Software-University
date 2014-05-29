using System;


class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        int choise = int.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1:
                Console.Write("Please enter a int: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Result : {0}",i + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Result : {0}",d + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string s = Console.ReadLine();
                Console.WriteLine("Result : {0}*",s);
                break;
            default:
                Console.WriteLine("You didn't enter a type in the range of [1..3]");
                break;
        }
    }
}
