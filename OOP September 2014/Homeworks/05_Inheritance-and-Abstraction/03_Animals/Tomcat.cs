using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.Male)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Tomcat: muaaaaaaaaaaa");
        }
    }
}
