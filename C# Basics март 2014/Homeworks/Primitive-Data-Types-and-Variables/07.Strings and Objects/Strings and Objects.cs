using System;


class StringsAndObjects
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object combination = firstWord + " " + secondWord;
        string a = (string)combination;
        Console.WriteLine(a);
    }
}
