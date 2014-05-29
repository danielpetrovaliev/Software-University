using System;


class Rectangles
{
    static void Main()
    {
        Console.Write("Insert a  width : ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Insert a height : ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter is : {0} \nArea is : {1}", (width + height) * 2, width * height);


    }
}
