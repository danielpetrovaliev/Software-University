using System;


class Point
{
    static void Main()
{
        Console.WriteLine("Please enter a X for point P(x,y):");
        double pointX = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a Y for point P(x,y):");
        double pointY = double.Parse(Console.ReadLine());
        double pointXcenterCircle = Math.Abs(pointX - 1);
        double pointYcenterCircle = Math.Abs(pointY - 1);
        bool inRectangle = false;
        bool inCircle = false;
 
        if (Math.Sqrt((pointXcenterCircle) * (pointXcenterCircle) + (pointYcenterCircle) * (pointYcenterCircle)) <= 1.5)
        {
            inCircle = true;
        }
        if (poi