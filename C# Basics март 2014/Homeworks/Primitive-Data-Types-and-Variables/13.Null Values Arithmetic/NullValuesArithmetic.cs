using System;


class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine("Printing the nullable variables:\n a = {0}\n b = {1} ", a, b);
        Console.WriteLine(a + 5);

        a += null;
        b += 3.1415926; // !Important - Adding value to null variable results null!
        Console.WriteLine("Printing the nullable sum variables:\n a= {0}\n b= {1}", a, b);

    }
}
