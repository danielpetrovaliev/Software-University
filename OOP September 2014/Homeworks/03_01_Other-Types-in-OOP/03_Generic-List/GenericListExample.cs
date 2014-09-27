using System;

class GenericListExample
{
    static void Main()
    {
        GenericList<int> dynamicList = new GenericList<int>(2);
        dynamicList.Add(1);
        dynamicList.Add(2);
        dynamicList.Add(3);
        dynamicList.Add(4);
        dynamicList.Add(5);
        dynamicList.Add(6);
        dynamicList.Add(7);
        dynamicList.Add(8);

        
        Console.WriteLine("Count: " + dynamicList.Count);
        Console.WriteLine(dynamicList);
        Console.WriteLine();
        var element = dynamicList.Access(4);
        Console.WriteLine("Element with index 4 is {0}", element);

        // Remove element
        Console.WriteLine();
        dynamicList.Remove(2);
        Console.WriteLine(dynamicList);

        // Insert element
        Console.WriteLine();
        dynamicList.Insert(3, 2);
        Console.WriteLine(dynamicList);

        // Min and Max number in list
        Console.WriteLine();
        Console.WriteLine("Min : " + dynamicList.Min());
        Console.WriteLine("Max : " + dynamicList.Max());

        // Clear list
        Console.WriteLine();
        dynamicList.Clear();
        
        Console.WriteLine(dynamicList);
        Console.WriteLine(dynamicList.Count);
        Console.WriteLine();

        var attributes = typeof(GenericList<>).GetCustomAttributes(typeof(Version), false);
        Console.WriteLine("Version: " + attributes[0]);

    }
}

