using System;


class QuotesInStrings
{
    static void Main()
    {
        string quoted = @"The ""use"" of quotations causes difficulties.";
        string normalstr = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("Normal String : {0}", normalstr);
        Console.WriteLine("Quoted String : {0}", quoted);
    }
}