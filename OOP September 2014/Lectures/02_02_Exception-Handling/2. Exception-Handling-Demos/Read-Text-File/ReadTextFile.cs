using System;
using System.IO;

class ReadTextFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\ReadTextFile.cs");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
            }
        }
    }
}
