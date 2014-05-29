using System;


class BooleanVariable
{
    static void Main()
    {
        int male = 1;
        int female = 2;
        bool isFemale = (male < female);
        Console.WriteLine("My gender is male: {0}", isFemale);
    }
}
