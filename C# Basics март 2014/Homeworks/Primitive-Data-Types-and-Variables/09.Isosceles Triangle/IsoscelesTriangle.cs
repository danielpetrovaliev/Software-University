using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        char symbol = '\u00a9';
        Console.OutputEncoding = Encoding.UTF8;            // Преди да стартирате променете шрифта на конзолата на "Consolas"
        Console.WriteLine(@"
    {0}
   {0} {0}
  {0}   {0}
 {0} {0} {0} {0}", symbol);
    }
}
