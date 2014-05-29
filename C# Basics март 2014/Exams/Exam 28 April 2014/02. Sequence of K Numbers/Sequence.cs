using System;



class Program
{
    static void Main()
    {
        
        string input = Console.ReadLine();
        string[] elements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < elements.Length; i++)
        {
            
        }
        Console.Write(elements);
    }
}