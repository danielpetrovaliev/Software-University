using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Enter_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            for (int i = 0; i < 10; i++)
            {
                ReadNumber(start, end);
            }
        }

        public static int ReadNumber(int start, int end)
        {
            int num = 0;
            Console.Write("Enter number in range[{0}...{1}]: ", start, end);
            num = int.Parse(Console.ReadLine());
            try
            {
                if (!(num <= end && num >= start))
                {
                    while (!(num <= end && num >= start))
                    {
                        Console.Write("You number is not in range. Please enter again: ");
                        num = int.Parse(Console.ReadLine());
                    }
                }
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid Number");
            }
            return num;
        }
    }
}
