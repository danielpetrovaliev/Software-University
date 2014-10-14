using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringDisperser
{
    class TestStringDisparser
    {
        static void Main(string[] args)
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");

            StringDisperser secondStringDisperser = new StringDisperser("gosho", "pesho", "tanio");

            StringDisperser clonedStringDisparser = (StringDisperser)secondStringDisperser.Clone();

            Console.WriteLine(stringDisperser == secondStringDisperser);
            Console.WriteLine(secondStringDisperser.Equals(clonedStringDisparser));

            Console.WriteLine(stringDisperser.CompareTo(secondStringDisperser));

            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
        }
    }
}
