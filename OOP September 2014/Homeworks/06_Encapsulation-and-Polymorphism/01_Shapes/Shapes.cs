using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    public class Shapes
    {
        static void Main(string[] args)
        {
            List<BasicShape> shapes = new List<BasicShape>()
            {
                new Triangle(5, 3, 60),
                new Triangle(10, 5, 90),
                new Rectangle(10, 20),
                new Rectangle(50, 20),
                new Circle(5),
                new Circle(10)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0}: Perimeter: {1:N2}, Area: {2:N2}", 
                    shape.GetType().Name, shape.CalculatePerimeter(), shape.CalculateArea());
            }
        }
    }
}
