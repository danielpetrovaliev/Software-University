using System;



class FitBoxInBox
{
    static void Main()
    {
        int w1 = int.Parse(Console.ReadLine());
        int h1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());
        int w2 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());

        var smaller = "";
        var bigger = "";
        if ((w1+h1+d1)<(w2+h2+d2))
        {
            smaller = "(" + w1 + ", " + h1 + ", " + d1 + ")";
            bigger = "(" + w2 + ", " + h2 + ", " + d2 + ")";
        }
        else
        {
            smaller = "(" + w2 + ", " + h2 + ", " + d2 + ")"; 
            bigger = "(" + w1 + ", " + h1 + ", " + d1 + ")";
        }
        
        if (w1 < w2 && h1 < h2 && d1 < d2)
        {
            Console.WriteLine(smaller + " < " + bigger);
        }


        if (w1 < w2 && h1 < d2 && d1 < h2)
        {
            bigger = "(" + w2 + ", " + d2 + ", " + h2 + ")";
            Console.WriteLine(smaller + " < " + bigger);
        }
        

        if (w1 < d2 && h1 < w2 && d1 < h2)
        {
            bigger = "(" + d2 + ", " + w2 + ", " + h2 + ")";
            Console.WriteLine(smaller + " < " + bigger);
        }
        

        if (w1 < d2 && h1 < h2 && d1 < w2)
        {
            bigger = "(" + d2 + ", " + h2 + ", " + w2 + ")";
            Console.WriteLine(smaller + " < " + bigger);
        }
        

        if (w1 < h2 && h1 < d2 && d1 < w2)
        {
            bigger = "(" + h2 + ", " + d2 + ", " + w2 + ")";
            Console.WriteLine(smaller + " < " + bigger);
        }
        

        if (w1 < h2 && h1 < w2 && d1 < d2)
        {
            bigger = "(" + h2 + ", " + w2 + ", " + d2 + ")";
            Console.WriteLine(smaller + " < " + bigger);
        }

        

        if (w2 < w1 && h2 < h1 && d2 < d1)
        {
            bigger = "(" + w1 + ", " + h1 + ", " + d1 + ")";
            Console.WriteLine(smaller + " < " + bigger);
        }

        if (w2 < w1 && h2 < d1 && d2 < h1)
        {
            bigger = "(" + w1 + ", " + d1 + ", " + h1 + ")";
            Console.WriteLine(smaller + " < " + bigger);
        }

        if (w2 < d1 && h2 < w1 && d2 < h1)
        {
            bigger = "(" + d1 + ", " + w1 + ", " + h1 + ")";
            Console.WriteLine(smaller + " < " + bigger);
        }

        if (w2 < d1 && h2 < h1 && d2 < w1)
        {
            bigger = "(" + d1 + ", " + h1 + ", " + w1 + ")";
            Console.WriteLine(smaller + " < " + bigger);
        }

        if (w2 < h1 && h2 < d1 && d2 < w1)
        {
            bigger = "(" + h1 + ", " + d1 + ", " + w1 + ")";
            Console.WriteLine(smaller + " < " + bigger);
        }

        if (w2 < h1 && h2 < w1 && d2 < d1)
        {
            bigger = "(" + h1 + ", " + w1 + ", " + d1 + ")";
            Console.WriteLine(smaller + " < " + bigger);
        }
    }
}