using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;


public static class DistanceCalculator
{
    public static double CalculateDistance(Point3D p1, Point3D p2)
    {
        double result = 0;
        result = Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2) + Math.Pow((p2.Z - p1.Z), 2));
        return result;
    }
    
}

