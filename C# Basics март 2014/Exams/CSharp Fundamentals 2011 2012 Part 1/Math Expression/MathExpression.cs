using System;


class Program
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double mod = m % 180;
        var exp = ((n * n) +(1 / m * n + 1337) / (n - 128.523123123 * p) + Math.Sin((int)mod);

        Console.WriteLine("{0:F6}",exp);
    }
}