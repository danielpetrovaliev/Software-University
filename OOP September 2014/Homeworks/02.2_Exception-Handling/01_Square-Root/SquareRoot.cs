using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Square_Root
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number to calculate square root: ");
                double number = Double.Parse(Console.ReadLine());
                double square = Math.Sqrt(number);
                Console.WriteLine("Square root of number is: {0}", square);

            }
            catch (FormatException)
            {
                
                throw new FormatException("Invalid number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
