using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    class DisplayPoint
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(2, 3, 8);
            Console.WriteLine("Problem 1. Point3D");
            Console.WriteLine(p1);
            Console.WriteLine(Point3D.StartingPoint);
            Console.WriteLine();

            Console.WriteLine("Problem 2. Distance Calculator");
            Point3D p = new Point3D(-7, -4, 3);
            Console.WriteLine(p);
            Point3D q = new Point3D(17, 6, 2.5);
            Console.WriteLine(q);
            Console.WriteLine();

            Console.WriteLine(DistanceCalculator.CalculateDistance(p, q));

            Console.WriteLine();
            Console.WriteLine("Write to File: ");
            _03_Paths path = new _03_Paths(p, q, Point3D.StartingPoint);
            Console.WriteLine(path);
            path.WriteToFile("../../points.txt");
            Console.WriteLine("Read From File: ");
            _03_Paths pathFromFile = _03_Paths.ReadFromFile("../../points.txt");
            Console.WriteLine(pathFromFile);
        }
    }
}
